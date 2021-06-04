using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public bool isPlayerOne;
    public float moveSpeed;
    public float jumpForce;
    public CharacterController contrroller;
    public GameManager managerGame;
    private Vector3 moveDirection;
    public float gravityScale;

    void Start()
    {
        contrroller = GetComponent<CharacterController>();
    }
    void Update()
    {
        if (isPlayerOne)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, moveDirection.y, Input.GetAxis("Vertical") * moveSpeed);
            if (contrroller.isGrounded)
            {
                moveDirection.y = 0f;
                if (Input.GetButtonDown("Jump"))
                {
                    moveDirection.y = jumpForce;
                    managerGame.managerSound.P1_Jump.Play();
                }
            }

        }
        else
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal2") * moveSpeed, moveDirection.y, Input.GetAxis("Vertical2") * moveSpeed);
            if (contrroller.isGrounded)
            {
                moveDirection.y = 0f;
                if (Input.GetButtonDown("Jump2"))
                {
                    moveDirection.y = jumpForce;
                    managerGame.managerSound.P2_Jump.Play();
                }
            }
        }


        moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale * Time.deltaTime);
        contrroller.Move(moveDirection * Time.deltaTime);

        //Game Stopped
        managerGame.managerUI.GameStopped();
    }   
}
