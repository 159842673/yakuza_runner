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
}
