using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventCamera : MonoBehaviour
{
    public float cameraspeed;
    public GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        cam.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = this.gameObject.transform.position;
        this.gameObject.transform.position = new Vector3(pos.x, pos.y, pos.z+cameraspeed);
        cameraspeed += Time.deltaTime;
   
        if (cameraspeed > 3)
        {
            
            Destroy(this.gameObject);
        }
  
    }
}
