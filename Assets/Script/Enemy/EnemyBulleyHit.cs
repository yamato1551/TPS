using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulleyHit : MonoBehaviour
{
    private PlayerStatus playerstatus;
    // Start is called before the first frame update
    void Start()
    {
        playerstatus = GameObject.Find("Player").GetComponent<PlayerStatus>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerstatus.Playerhp -= 1;
            playerstatus.isDamage = true;
            //Debug.Log("hit");
        }
    }

}