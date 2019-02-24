using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShotShell : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform muzzle;
    public float shotspeed;
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count += 1;
        //100フレームごとに実行する
        if (count % 80 == 0)
        {
            EnemyShot();
        }
    }
    public void EnemyShot()
    {
        GameObject bullet = Instantiate(bulletPrefab) as GameObject;
        Vector3 force;
        force = this.gameObject.transform.forward * shotspeed;
        bullet.GetComponent<Rigidbody>().AddForce(force);
        bullet.transform.position = muzzle.position;
        Destroy(bullet, 2f);
    }
}
