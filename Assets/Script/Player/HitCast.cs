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
    public GameObject RHG;
    public bool hitflag;
    void Update()
    {
        hitflag = false;
        image.sprite = NUI;
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        int distance = 120;
        Debug.DrawLine(ray.origin, ray.direction * distance, Color.red);
        if (Physics.Raycast(ray,out hit, distance))
        {
            if (hit.collider.tag == "Enemy"||hit.collider.tag=="EnemyBullet")
            {
                hitflag = true;
                RHG.transform.position = new Vector3(hit.point.x, hit.point.y, hit.point.z);
                image.sprite = ColorChangeUI;
            }
           
        }
    }
}
