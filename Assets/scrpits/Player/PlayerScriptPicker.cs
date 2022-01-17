using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScriptPicker : MonoBehaviour
{
    public GameObject playerSolo, player1;

    private void Start()
    {
        if (PlayerInputManager.instance.playerCount == 1)
        {
            Instantiate(playerSolo, transform);
        }
        else
        {
            var solo = FindObjectOfType<Player>().transform;
            var soloPosition = solo.position;
            var soloParent = solo.parent;
            Destroy(solo.gameObject);
            Instantiate(player1, soloPosition, quaternion.identity, soloParent);
        }
    }
}