using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TpsCam : MonoBehaviour
{
    float mouseMoveY;
    public Transform target;
    public GameObject targetobj;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        if (StageManager.pause == true)
        {
            mouseMoveY = Input.GetAxis("MouseY") * 1;
            Vector3 pos = target.transform.position;

            pos.y += mouseMoveY;
            pos.y = Mathf.Clamp(pos.y, pos.y - 30, pos.y + 30);
            target.transform.position = pos;

            mouseMoveY = Input.GetAxis("MouseY2") * (1f / 20f);
            Vector3 campos = transform.position;
            Vector3 playerpos = targetobj.transform.position;
            campos.y += mouseMoveY;
            campos.y = Mathf.Clamp(campos.y, playerpos.y - 1, playerpos.y + 4);
            transform.position = campos;
        }
    }
}
   
