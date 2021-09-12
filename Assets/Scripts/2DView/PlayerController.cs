using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float speed, jumpSpeed, lookSpeed, lookYLimit, gravity;

    [SerializeField]
    float cameraRange, cameraSpeed;

    public bool lookDown;
    Vector3 cameraTarget;
    Vector3 movePos;
    Vector3 lastPos;
    CharacterController characterController;
    GameObject mainCamera;

    public float testX, testY;


    public enum State
    {
        IDLE,
        WALK,
        JUMP,
        DJUMP,
        SIT,
        UPVIEW,
    }

    public State playerState = State.IDLE;

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
        testX = xpos;
        testY = ypos;

        float movementDirectionY = movePos.y;

        if (ypos < 0 && characterController.isGrounded)
        {
            xpos = 0;
            ChangeState(State.SIT);
        }
        else
        {
            if (characterController.isGrounded)
            {
                if(xpos == 0)
                {
                    ChangeState(State.IDLE);
                }
                else
                {
                    ChangeState(State.WALK);
                }
            }
        }
        movePos = (forward * xpos);

        

        if (playerState != State.SIT || playerState != State.JUMP)
        {
            if (ypos > 0 && !GetSpeed())
            {
                ChangeState(State.UPVIEW);
            }
        }
        
        if (Input.GetButtonDown("Jump") && playerState == State.JUMP)
        {
            ChangeState(State.DJUMP);
        }
        else
        {
            movePos.y = movementDirectionY;
        }

        if (Input.GetButtonDown("Jump") && characterController.isGrounded)
        {
            ChangeState(State.JUMP);
        }
        
        switch (playerState)
        {
            case State.IDLE:
                IDLE();
                break;
            case State.WALK:
                WALK();
                break;
            case State.JUMP:
                JUMP();
                break;
            case State.DJUMP:
                DJUMP();
                break;
            case State.SIT:
                SIT();
                break;
            case State.UPVIEW:
                UPVIEW();
                break;
        }

        characterController.Move(movePos * Time.deltaTime);
        movePos.y -= gravity * Time.deltaTime;
        mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, cameraTarget, lookSpeed * Time.deltaTime * cameraSpeed);
    }

    public bool GetSpeed()
    {
        float moveSpeed = Vector3.Distance(transform.position, lastPos);
        lastPos = transform.position;

        return moveSpeed == 0 ? false : true;
    }

    public void ChangeState(State state)
    {

        switch (state)
        {
            case State.IDLE:
                SetIDLE();
                break;
            case State.WALK:
                SetWALK();
                break;
            case State.JUMP:
                SetJUMP();
                break;
            case State.DJUMP:
                SetDJUMP();
                break;
            case State.SIT:
                SetSIT();
                break;
            case State.UPVIEW:
                SetUPVIEW();
                break;
        }

        playerState = state;
    }

    void IDLE()
    {
        cameraTarget = transform.position + new Vector3(cameraRange, 1.5f, 0);
    }
    void WALK()
    {
        cameraTarget = transform.position + new Vector3(cameraRange, 1.5f, 0);
    }
    void JUMP()
    {
        cameraTarget = transform.position + new Vector3(cameraRange, 1.5f, 0);
    }
    void DJUMP()
    {
        cameraTarget = transform.position + new Vector3(cameraRange, 1.5f, 0);
    }
    void SIT()
    {
        cameraTarget = transform.position + new Vector3(cameraRange, -lookYLimit, 0);
    }
    void UPVIEW()
    {
        cameraTarget = transform.position + new Vector3(cameraRange, lookYLimit * 2, 0);
    }

    void SetIDLE()
    {

    }
    void SetWALK()
    {

    }
    void SetJUMP()
    {
        movePos.y = jumpSpeed;
    }
    void SetDJUMP()
    {
        movePos.y = jumpSpeed;
    }
    void SetSIT()
    {

    }
    void SetUPVIEW()
    {

    }
}
