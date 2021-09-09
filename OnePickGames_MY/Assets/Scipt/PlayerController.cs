using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float speed, jumpSpeed, lookSpeed, lookXLimit, gravity;

    GameObject playerCamera;
    float rotationX = 0;

    Vector3 movePos;
    CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
        characterController = gameObject.GetComponent<CharacterController>();
        playerCamera = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);
        float xpos = Input.GetAxis("Vertical") * speed;
        float ypos = Input.GetAxis("Horizontal") * speed;
        float movementDirectionY = movePos.y;
        movePos = (forward * xpos) + (right * ypos);

        if (Input.GetButton("Jump") && characterController.isGrounded)
        {
            movePos.y = jumpSpeed;
        }
        else
        {
            movePos.y = movementDirectionY;
        }

        if (!characterController.isGrounded)
        {
            movePos.y -= gravity * Time.deltaTime;
        }

        characterController.Move(movePos * Time.deltaTime);


        rotationX += -Input.GetAxis("Mouse Y") * lookSpeed;
        rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);
        playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
        transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed, 0);
    }
}