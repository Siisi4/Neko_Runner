using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FishReward : MonoBehaviour
{
    public Text Fish;
    private int rewards;
    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Player")){
            Debug.Log("Fish obtained");
            rewards +=1;
            Fish.text = rewards.ToString();
        }
    }
    
}
