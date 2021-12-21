using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoves : MonoBehaviour
{
    public float CameraSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(CameraSpeed, 0, 0 * Time.deltaTime);
    }

    void FixedUpdate() {
        
    }
}
