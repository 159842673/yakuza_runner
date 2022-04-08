using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [Header("Levels To Load")]

    private string levelToload;


    public void NewGameDialogYes()
    {
        SceneManager.LoadScene(1);
    }

    public void Lambda()
    {
        SceneManager.LoadScene(2);
    }
    public void DroneGroup()
    {
        SceneManager.LoadScene(3);
    }
    public void Miniboss()
    {
        SceneManager.LoadScene(4);
    }
    public void Ninja()
    {
        SceneManager.LoadScene(5);
    }
    public void Kamikaze()
    {
        SceneManager.LoadScene(6);
    }
    public void Scenemobs()
    {
        SceneManager.LoadScene(7);
    }
}
