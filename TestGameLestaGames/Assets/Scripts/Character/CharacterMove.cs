using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterMove : MonoBehaviour, IMoveable
{
    public PlayerState playerState;
    [SerializeField] private CharacterController characterController;

    [SerializeField] private float speedMove;

    [SerializeField] private float gravity;

    [SerializeField] private Vector3 move;

    private float inputHorizontal;
    private float inputVertical;
    public void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal"); 
        inputVertical = Input.GetAxis("Vertical");

        if (inputHorizontal != 0f || inputVertical != 0f)
            Move();
        else
            Idle();

        if(characterController.isGrounded == false)
        {
            move = new Vector3(inputVertical, gravity, -inputHorizontal);
            characterController.Move((move * speedMove) * Time.deltaTime);
        }

    }
    public void Idle()
    {
        playerState = PlayerState.idle;

        Debug.Log("i'm idle");
    }

    public void Move()
    {
        move = new Vector3(inputVertical, 0f, -inputHorizontal);

        characterController.Move((move * speedMove) * Time.deltaTime);

        Quaternion targetRotation = Quaternion.LookRotation(move);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 10f); // Плавное вращение


        playerState = PlayerState.move;
        Debug.Log("i'm move");
    }
}
