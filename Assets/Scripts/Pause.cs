using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public GameObject pausebutton;
    public GameObject TimeManager;
    void Update()
    {
        if(Input.GetKey("escape")){
            Debug.Log("Game is paused !");
            Time.timeScale = 0;
            pausebutton.SetActive(true);
            TimeManager.SetActive(false);
        }
    }

    public void ContinueGame(){
        Debug.Log("Game is now playing !");
        Time.timeScale = 1;
        pausebutton.SetActive(false);
        TimeManager.SetActive(true);
    }


}
