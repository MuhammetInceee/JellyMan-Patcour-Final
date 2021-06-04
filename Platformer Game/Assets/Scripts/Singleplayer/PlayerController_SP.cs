using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_SP : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    public CharacterController controller;
    public GameManager_SP managerGame_SP;
    private Vector3 moveDirection;
    public float gravityScale;
    private float myVerticalAxis;
    private float myHorizontalAxis;

    void Start()
    {
        controller = GetComponent<CharacterController>();

    }
    void Update()
    {
        myHorizontalAxis = Input.GetAxis("Horizontal");
        myVerticalAxis = Input.GetAxis("Vertical");

        float yStore = moveDirection.y;
        moveDirection = (transform.forward * myVerticalAxis * moveSpeed) + (transform.right * myHorizontalAxis * moveSpeed);
        moveDirection.y = yStore;

        if (controller.isGrounded)
        {
            moveDirection.y = 0f;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                moveDirection.y = jumpForce;
                managerGame_SP.managerAudio_SP.jumpSound.Play();
            }

        }
        moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale * Time.deltaTime);
        controller.Move(moveDirection * Time.deltaTime);

        //Game Stopped
        managerGame_SP.managerUI_SP.GameStopped();

    }
}
