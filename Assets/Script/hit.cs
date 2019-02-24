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
      
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        Vector3 bulletpos = this.gameObject.transform.position;
       
        if (count >= 3)
        {
            Destroy(this.gameObject);
        }
        
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Wall")
        {
            Debug.Log("Destroy");
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
