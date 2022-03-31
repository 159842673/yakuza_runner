using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class Multiplayer : MonoBehaviour
{
    public GameObject playerSolo, player1, player2;

    private void Start()
    {
        if (PlayerInputManager.instance.playerCount == 1)
        {
            Instantiate(playerSolo, transform);
        }
        else
        {
            var solo = FindObjectOfType<Move2D>().transform;
            var soloPosition = solo.position;
            var soloParent = solo.parent;
            Destroy(solo.gameObject);
            Instantiate(player1, soloPosition, quaternion.identity, soloParent);
            Instantiate(player2, transform);
        }
    }
}