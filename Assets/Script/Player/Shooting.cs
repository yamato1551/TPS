using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    public Transform muzzle;
    public float speed = 1000;
    public float count = 0.5f;
    public AudioClip Shot;
    private AudioSource audiosouce;
    //GameObject enemy;

    void Start()
    {
        audiosouce = gameObject.GetComponentInParent<AudioSource>();
        
        //enemy = GameObject.Find("Enemy");

    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (changecount > 0.2f)
        {
            calflag = false;
        }
        else
        {
            calflag = true;
        }
        if (calflag == false)
        {
            enemy.GetComponent<Renderer>().material.color = new Color(1, 1, 1);

        }
        else
        {
            enemy.GetComponent<Renderer>().material.color = new Color(200f/255f, 50f/255f, 50f/255f);

        }
        
        changecount += Time.deltaTime;
    */
        //Debug.Log("ChangeCount:" + changecount);
        if (StageManager.pause == true)
        {
            count += Time.deltaTime;
            if (count > 0.1f)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    audiosouce.clip = Shot;
                    audiosouce.Play();
                    GameObject bullets = Instantiate(bullet) as GameObject;
                    Vector3 force;
                    force = this.gameObject.transform.forward * speed;
                    bullets.GetComponent<Rigidbody>().AddForce(force);
                    bullets.transform.position = muzzle.position;
                    count = 0;
                }
            }
        }
    }

}
