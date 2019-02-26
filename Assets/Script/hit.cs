using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hit : MonoBehaviour
{
    public float count;
    //int Hit = 0;
    public GameObject particlebox;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 bulletpos = this.gameObject.transform.position;
        Destroy(this.gameObject,0.1f);     
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Wall")
        {
            //Debug.Log("Destroy");
            Destroy(this.gameObject);
            
        }
        if (other.gameObject.tag == "Enemy")
        {
            Instantiate(particlebox, this.transform.position, Quaternion.identity);
            Debug.Log("hit");
            Destroy(this.gameObject);

        }

    }
   

}
