using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenEdges : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    // Ceci prend en compte la vue dans l'editor mais ne devrait pas être un pb pour le built du jeu !
    public GameObject Kitty;
    void OnBecameInvisible() {
 	Destroy(Kitty);
    Debug.Log("Neko is out of screen !");
    }
}
