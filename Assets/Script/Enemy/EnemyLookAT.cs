using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLookAT : MonoBehaviour
{
    public GameObject targetobj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 0.1f;
        Vector3 relativepos = targetobj.transform.position - this.transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativepos);
        transform.rotation = Quaternion.Slerp(this.transform.rotation, rotation, speed);
        
    }
}
