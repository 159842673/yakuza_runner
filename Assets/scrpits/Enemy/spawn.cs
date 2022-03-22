using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class spawn : MonoBehaviour
{
    public GameObject ennemyprefab;
    public float MinvalueY;
    public float MaxvalueY;
    public float ennemydestroytime = 11f;
    public float spawnx;
    private void Awake()
    {
     
    }
    void Start()
    {
        InvokeRepeating("instantiatenemy", 4f, 10f);
    }
    void instantiatenemy()
    {
        Vector3 enemypos = new Vector3(spawnx, Random.Range(MinvalueY, MaxvalueY));
        GameObject respawn = Instantiate(ennemyprefab, enemypos, Quaternion.identity);
        Destroy(respawn, ennemydestroytime);
    }
    IEnumerator RNBSPAWN()
    {
        while (true)
        {
        }
    }
}


