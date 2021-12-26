using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoves : MonoBehaviour
{
    public float CameraSpeed;
    public GameObject Camera;

    void Update()
    {
        Camera.transform.Translate(CameraSpeed, 0, 0 * Time.deltaTime);
    }

}
