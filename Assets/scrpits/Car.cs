using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.Vehicles.Car;

public class CarEnter : MonoBehaviour
{

    public GameObject player;
    public GameObject car;
    public GameObject carCamera;

    private bool canEnter;
    private bool isInside;
   

    private float timeLeft;
    private bool canLeave = false;

    private void Start()
    {
        car = transform.parent.gameObject;
        player = GameObject.FindGameObjectWithTag("Player");
        timeLeft = 1f;
    }

    void Update()
    {

        // Si on entre dans la voiture
        if (canEnter && Input.GetKeyDown("e"))
        {
            isInside = true;

            player.transform.parent = car.transform;
            player.SetActive(false);

            carCamera.SetActive(true);

            car.GetComponent<CarController>().enabled = true;
            car.GetComponent<CarUserControl>().enabled = true;
            car.GetComponent<CarAudio>().enabled = true;

            timeLeft = 1f;

        }

        // Si on sort de la voiture
        if (isInside && canLeave && Input.GetKeyDown("e"))
        {
            player.transform.parent = null;
            player.SetActive(true);

            carCamera.SetActive(false);

            car.GetComponent<CarController>().enabled = false;
            car.GetComponent<CarUserControl>().enabled = false;
            car.GetComponent<CarAudio>().enabled = false;

            isInside = false;
            canLeave = false;

            timeLeft = 1f;

           
        }

        // Délais d'attente entre l'entrée et la sortie de la voiture
        // (Permet aussi d'utiliser la même touche pour entrer et sortir)
        if (timeLeft > 0 && isInside)
        {
            timeLeft -= Time.deltaTime;
            canLeave = false;
        }
        else if (timeLeft <= 0 && isInside)
        {
            canLeave = true;
        }
    }

    // Detection du joueur dans le cube d'entrée
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            canEnter = true;
        }
    }

    void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            canEnter = false;
        }
    }

}