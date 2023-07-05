using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera3D : MonoBehaviour
{
    public float sensX;
    public float sensY;

    public Transform Orientation;

    [SerializeField]float RotatioinX;
    [SerializeField] float RotatioinY;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Mouse Input
        float MouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float MouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;
        Debug.Log(MouseX + " " + MouseY);
        RotatioinY += MouseX;
        RotatioinX -= MouseY;
        RotatioinX = Mathf.Clamp(RotatioinX, -90.0f, 90f);

        // Rotate cam and orientation
        transform.rotation = Quaternion.Euler(RotatioinX, RotatioinY, 0);
        Orientation.rotation = Quaternion.Euler(0, RotatioinY, 0);
    }
}