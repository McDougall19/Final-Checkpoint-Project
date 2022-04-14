using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    private float verticalSpeed = -0.5f;
    private float horizontalSpeed = 0.5f;

    private float vMovement = 0.0f;
    private float hMovement = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vMovement += verticalSpeed * Input.GetAxis("Mouse Y");
        hMovement += horizontalSpeed * Input.GetAxis("Mouse X");

        transform.eulerAngles = new Vector3(vMovement, hMovement, 0.0f);

        
    }
}
