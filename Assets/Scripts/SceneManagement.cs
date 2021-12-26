using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void PlayButton(){
        SceneManager.LoadScene("LevelA");
    }

    public void QuitGame(){
        Application.Quit();
        Debug.Log("Application.Quit");
    }
}
