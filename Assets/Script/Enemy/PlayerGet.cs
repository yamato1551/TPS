using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGet : MonoBehaviour
{
    private EnemyShotShell shot;
    void Start()
    {
        shot = GetComponentInParent<EnemyShotShell>();
    }
    void OnTriggerStay(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            //Debug.Log("Player");
            shot.shotflag=true;
            shot.getcount = 0;
        }
    }
}