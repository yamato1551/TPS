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
    public AudioClip jumpSE;
    private AudioSource audiosouce;
     void Start()
    {
        audiosouce = gameObject.GetComponent<AudioSource>();
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
                audiosouce.clip = jumpSE;
                audiosouce.Play();
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
            if (Input.GetKey(KeyCode.W)&&jumpflag==true)
            {
                Animain.SetBool("Run",true);
            }
            else
            {
                Animain.SetBool("Run",false);
                Animain.SetTrigger("Idle");
            }
            if (Input.GetKey(KeyCode.S) && jumpflag == true)
            {
                Animain.SetBool("Back", true);
            }
            else
            {
                Animain.SetBool("Back", false);
                Animain.SetTrigger("Idle");
            }
            if (Input.GetKey(KeyCode.A) && jumpflag == true)
            {
                Animain.SetBool("Left", true);
            }else
            {
                Animain.SetBool("Left", false);
                Animain.SetTrigger("Idle");
            }
            if (Input.GetKey(KeyCode.D) && jumpflag == true)
            {
                Animain.SetBool("Right", true);
            }
            else
            {
                Animain.SetBool("Right", false);
                Animain.SetTrigger("Idle");
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
            Vector3 groudobjpos = collision.gameObject.transform.position;
            Vector3 pos = this.gameObject.transform.position;
            pos.y = 1.6f;
            this.gameObject.transform.position=new Vector3(pos.x, pos.y+groudobjpos.y, pos.z);
            Debug.Log(pos);
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
