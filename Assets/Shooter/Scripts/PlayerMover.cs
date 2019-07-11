using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] float speed;
    private CharacterController c_Control;
    Vector3 movePosition;
    [SerializeField] GameObject mainCamera;
    [SerializeField] string[] mouseState;
    [SerializeField] float mouseSens;

    

    private void Start()
    {
        if (ReferenceEquals(c_Control, null))
        {
            c_Control = GetComponent<CharacterController>();
        }
        else {
            return;


        }
        LockCursor();
    }
    private void Update()
    {
        MoveMethod();
        CameraMove();
    }

    public void MoveMethod() {
        float xPos = Input.GetAxis("Horizontal");
        float zPos = Input.GetAxis("Vertical");
        movePosition = new Vector3(xPos * Time.deltaTime * speed, 0f, zPos * Time.deltaTime * speed);
        c_Control.Move(movePosition);
    }
    public void CameraMove() {
        float x = Input.GetAxis(mouseState[0]) * mouseSens * Time.deltaTime;
        float y = Input.GetAxis(mouseState[1]) * mouseSens * Time.deltaTime;

        transform.Rotate(-transform.right * y);
    }

    public void LockCursor() {
        Cursor.lockState  = CursorLockMode.Locked;
    }
}
