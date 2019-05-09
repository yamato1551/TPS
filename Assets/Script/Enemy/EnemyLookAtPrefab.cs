using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLookAtPrefab : MonoBehaviour
{
    private GameObject targetobj;
    //public GameObject Player;
    //public Transform lookatposition;
    public float speed;
    public bool tarobj;
    // Update is called once per frame
    void Start()
    {
        if (tarobj)
        {
            targetobj = GameObject.Find("Player");

        }
        else
        {
            targetobj = GameObject.Find("/Player/FloatingEnemyLookAtpositon");
        }
    }
    void Update()
    {
        Vector3 relativepos = targetobj.transform.position - this.transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativepos);
        transform.rotation = Quaternion.Slerp(this.transform.rotation, rotation, speed);
    }
}
