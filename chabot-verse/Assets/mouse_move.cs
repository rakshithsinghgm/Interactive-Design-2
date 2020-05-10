using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_move : MonoBehaviour
{
    public float mouse_sensitivity = 100F;
    public Transform playerbody;
    float xRotation = 0F;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouse_sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouse_sensitivity * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90F, 90F);
        transform.localRotation = Quaternion.Euler(xRotation, 0F, 0F);
        playerbody.Rotate(Vector3.up * mouseX);
    }
}
