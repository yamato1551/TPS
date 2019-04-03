using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructableBullet : MonoBehaviour
{
    public GameObject destroyeffect;
   void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            Debug.Log("hit");
            Instantiate(destroyeffect);
            Destroy(this.gameObject);
        }
    }
}
