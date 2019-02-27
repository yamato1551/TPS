using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShotShell : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform muzzle;
    public float shotspeed;
    private int count;
    public bool shotflag;
    public float getcount;
     // Start is called before the first frame update
    void Start()
    {
        getcount = 5;
        shotflag = false;
     }

    // Update is called once per frame
    void Update()
    {
        getcount += Time.deltaTime;
        getcount = Mathf.Clamp(getcount, 0, 5);
        if (shotflag==true)
        {
            count += 1;
            //フレームごとに実行する
            if (count % 80 == 0)
            {
                EnemyShot();
            }
        }
        if (getcount >= 5)
        {
            shotflag = false;
        }
    }
    
    public void EnemyShot()
    {
        if (StageManager.pause==true)
        {
            GameObject bullet = Instantiate(bulletPrefab) as GameObject;
            Vector3 force;
            force = this.gameObject.transform.forward * shotspeed;
            bullet.GetComponent<Rigidbody>().AddForce(force);
            bullet.transform.position = muzzle.position;
            Destroy(bullet, 5f);
        }
    }
}
