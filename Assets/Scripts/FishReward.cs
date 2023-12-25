using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[RequireComponent(typeof(AudioSource))]

public class FishReward : MonoBehaviour
{
    public Text Fish;
    private int rewards;
    public AudioSource obtained;
    //public AudioSource obtained;

    private void Start()
    {
        //obtained = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("reward")){
            Debug.Log("Fish obtained");
            obtained.Play(0);
            rewards +=1;
            Fish.text = rewards.ToString();
            Destroy(other.gameObject);
        }
    }
    
}
