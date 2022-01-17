using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomnspawn : MonoBehaviour
{
    [SerializeField] GameObject[] RNGSPAWN;
    [SerializeField] float Secondspawn = 0.5f;
    [SerializeField] float MinTras;
    [SerializeField] float Maxtras;
    [SerializeField] float spawnx;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RNBSPAWN());
    }

    // Update is called once per frame
    IEnumerator RNBSPAWN()
    {
        while (true)
        {
            var wanted = Random.Range(MinTras, Maxtras);
            var position = new Vector3(wanted, transform.position.y);
            Vector3 enemypos = new Vector3(spawnx, Random.Range(MinTras, Maxtras));
            GameObject gameObject = Instantiate(RNGSPAWN[Random.Range(0, RNGSPAWN.Length)], enemypos , Quaternion.identity);
            yield return new WaitForSeconds(Secondspawn);
        }
    }
}
