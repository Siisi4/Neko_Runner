using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreOverTime : MonoBehaviour
{
    private float timer;
    private int score;
    public Text ScoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 1f){
            score +=1;
            ScoreText.text = score.ToString();
            //timer = 0;
        }

    }
}
