using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLookAT : MonoBehaviour
{
    public GameObject targetobj;
    public float speed;
    // Update is called once per frame
    void Update()
    {
        Vector3 relativepos = targetobj.transform.position - this.transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativepos);
        transform.rotation = Quaternion.Slerp(this.transform.rotation, rotation, speed);
    }
}
