using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    
    public float speed = 3f;
    float moveX =0;
    float moveY = 0;
    float moveZ = 0;
    float mouseMoveX;
    float mouseMoveY;
    public float sentivity = 0.5f;
    Rigidbody rb;
    [Range(1.0f, 20.0f)]
    public float jump;
    float gravity;
    public bool jumpflag=true;
    private Animator Animain;
     void Start()
    {
        Animain = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        if (StageManager.pause == true)
        {
            //gravity = 0;
            mouseMoveX = Input.GetAxis("MouseX") * sentivity;
            transform.Rotate(0, mouseMoveX, 0);

            Transform mytransform = this.transform;
            if (jumpflag == true)
            {
                moveX = Input.GetAxis("Horizontal") * speed;
                moveZ = Input.GetAxis("Vertical") * speed;

            }
            mytransform.Translate(moveX, moveY, moveZ);
            if (Input.GetKey(KeyCode.Space) && jumpflag == true)
            {
                Animain.SetTrigger("Jump");
                moveY += jump;
                jumpflag = false;
                gravity = 0;
            }
            if (jumpflag == false)
            {
                gravity = 0.05f;
                moveY -= gravity;
            }
        }
    }
   
    void FixedUpdate()
    {
        rb.velocity = new Vector3(moveX, 0, moveZ);    
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            //Animain.SetBool("Jump", false);
            jumpflag = true;
            moveY = 0;
            gravity = 0;
        }    
    }
    void OnCollisionExit(Collision colision)
    {
        jumpflag = false;
    }
}
