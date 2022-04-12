using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public Transform cameraTransform;
    private float verticalSpeed = -0.5f;
    private float horizontalSpeed = 0.5f;

    public Vector3 pitchMinMax = new Vector3(-90, 90);

    private float pitch, yaw;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        pitch -= verticalSpeed * Input.GetAxis("Mouse Y");
        yaw += horizontalSpeed * Input.GetAxis("Mouse X");


        pitch = Mathf.Clamp(pitch, pitchMinMax.x, pitchMinMax.y);

        transform.rotation = Quaternion.AngleAxis(yaw, Vector3.up);
        cameraTransform.rotation = Quaternion.AngleAxis(pitch, cameraTransform.right);
    }
}
