using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HitCast : MonoBehaviour
{
    public Image image;
    public Sprite NUI;
    public Sprite ColorChangeUI;
    public Sprite ChangeUI;
    void Start()
    {
       //image = this.GetComponent<Image>();

    }
    void Update()
    {

        image.sprite = NUI;

        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        int distance = 1000;
        Debug.DrawLine(ray.origin, ray.direction * distance, Color.red);
        if(Physics.Raycast(ray,out hit, distance))
        {
            if (hit.collider.tag == "Enemy")
            {
                Debug.Log("rayhit");
                image.sprite = ColorChangeUI;
                //image.sprite = ChangeUI;
            }
        }
        /*
        Ray ray = new Ray();
        RaycastHit hit = new RaycastHit();
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        if (Physics.Raycast(transform.position, fwd, 1000))
        {
            if (hit.collider.tag == "enemy")
            {
                Debug.Log("rayhit");
            }
        }
        */
    }
}
