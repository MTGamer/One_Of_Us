using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCamera : MonoBehaviour
{
    // Varibles
    public Transform playerBody;
    public float sensitivity = 5;
    public bool locksOnStart = false;

    private float XROT;

    // Start is called before the first frame update
    void Start()
    {
        if (locksOnStart)
        {
            lockMouse();
        }
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        XROT -= mouseY;
        XROT = Mathf.Clamp(XROT, -90, 90);

        playerBody.Rotate(0, mouseX, 0);
        transform.localRotation = Quaternion.Euler(XROT, 0, 0);
    }

    public void lockMouse()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
