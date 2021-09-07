using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    [SerializeField]
    float speed, jumpSpeed, lookSpeed, lookYLimit, gravity;

    [SerializeField]
    float cameraRange;

    public bool lookDown;
    Vector3 cameraTarget;
    Vector3 movePos;
    Vector3 lastPos;
    CharacterController characterController;
    GameObject mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        characterController = gameObject.GetComponent<CharacterController>();
        mainCamera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float xpos = Input.GetAxis("Horizontal") * speed;
        float ypos = Input.GetAxis("Vertical");
        float movementDirectionY = movePos.y;
        



        if (ypos < 0 && characterController.isGrounded)
        {
            xpos = 0;
            lookDown = true;
        }
        else
        {
            lookDown = false;
        }
        movePos = (forward * xpos);

        /*if (Input.GetButton("Jump") && characterController.isGrounded)
        {
            movePos.y = jumpSpeed;
        }
        else
        {
            movePos.y = movementDirectionY;
        }*/

        if (Input.GetButton("Jump") && characterController.isGrounded)
        {
            movePos.y = jumpSpeed;
        }
        else
        {
            movePos.y = movementDirectionY;
        }

        

        

        //cameraTarget = transform.position + new Vector3(cameraRange, 1.5f, 0);

        if (lookDown)
        {
            cameraTarget = transform.position + new Vector3(cameraRange, -lookYLimit, 0);
        }
        else
        {
            
            if(ypos > 0 && !GetSpeed())
            {
                cameraTarget = transform.position + new Vector3(cameraRange, lookYLimit*2, 0);
            }
            else
            {
                cameraTarget = transform.position + new Vector3(cameraRange, 1.5f, 0);
            }
        }

        characterController.Move(movePos * Time.deltaTime);

        movePos.y -= gravity * Time.deltaTime;

        mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, cameraTarget, lookSpeed * Time.deltaTime);
    }

    public bool GetSpeed()
    {
        float moveSpeed = Vector3.Distance(transform.position, lastPos);
        lastPos = transform.position;

        return moveSpeed == 0 ? false : true;
    }
}
