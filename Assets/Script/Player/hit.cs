using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hit : MonoBehaviour
{
    public float count;
    //int Hit = 0;
    public GameObject HitEffect;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 bulletpos = this.gameObject.transform.position;
        Destroy(this.gameObject,count);     
    }
    void OnCollisionEnter(Collision collision)
    {

        Destroy(this.gameObject);

        if (collision.gameObject.tag == "Enemy")
        {
            Instantiate(HitEffect, this.transform.position, Quaternion.identity);
        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BossEnemyBullet")
        {
            Destroy(this.gameObject);
            Instantiate(HitEffect, this.transform.position, Quaternion.identity);
        }
    }
}
