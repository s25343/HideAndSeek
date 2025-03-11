using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekerMouse : MonoBehaviour
{
    public float mouseSensetivity = 500f;

    float xR = 0f;
    float yR = 0f;

    public float topClamp = -90f;
    public float bottomClamp = -90f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensetivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensetivity * Time.deltaTime;
    
        xR -= mouseY;
        xR = Mathf.Clamp(xR, topClamp, bottomClamp);

        yR += mouseX;
        transform.localRotation = Quaternion.Euler(xR, yR, 0f);
    }
}
