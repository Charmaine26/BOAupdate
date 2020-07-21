using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    float speed = 4;
    float rotspeed = 80;
    float rot = 0f;
    float gravity = 8;

    Vector3 moveDir = Vector3.zero;

    CharacterController controller;
    Animator anim;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (controller.isGrounded)
        {
            if (Input.GetKey (KeyCode.W))
            {
                anim.SetInteger("condition", 1);
                moveDir = new Vector3(0, 0, 1);
                moveDir *= speed;
                moveDir = transform.TransformDirection (moveDir);
            }
            if(Input.GetKeyUp(KeyCode.W))
            {
                 anim.SetInteger("condition", 0);
                 moveDir = new Vector3(0, 0, 0);
            }

            if (Input.GetKey (KeyCode.S))
            {
                anim.SetInteger("condition", 2);
                moveDir = new Vector3(0, 0, 0);
                moveDir *= speed;
                moveDir = transform.TransformDirection (moveDir);
            }
            if(Input.GetKeyUp(KeyCode.S))
            {
                 anim.SetInteger("condition", 0);
                 moveDir = new Vector3(0, 0, 0);
            }

        }
        rot += Input.GetAxis("Horizontal") * rotspeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, rot, 0);

        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);
    }

}
