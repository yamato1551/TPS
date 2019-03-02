using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyAI : MonoBehaviour
{
    private Vector3 move;
    public int enemyMaxHP = 5;
    private int Enemyhp;
    public float speed;
    public GameObject enemyDeath;
    private EnemyHPStatusUI hpStatusUI;
    //public float pos;
    private Vector3 nowpos;
    private Vector3 pos;
    public Vector3 movepos;
    public bool directionx,directionz,moveflagx,moveflagz;
   // Start is called before the first frame update
    void Start()
    {
        pos = this.gameObject.transform.position;
        StageManager.EnemyNum += 1;
        Enemyhp = enemyMaxHP;
        hpStatusUI = GetComponentInChildren<EnemyHPStatusUI>();
        nowpos.x = pos.x;
        nowpos.y = pos.y;
        nowpos.z = pos.z;
        movepos.x = nowpos.x + movepos.x;
        movepos.y = nowpos.y + movepos.y;
        movepos.z = nowpos.z + movepos.z;
    }

    // Update is called once per frame
    void Update()
    {
        pos = this.gameObject.transform.position;
        /*
        count = Random.Range(1,10);
        changecount += Time.deltaTime;
        if (changecount > count) {
            x = Random.Range(-40, 40);
            y = 2.5f;
            z = Random.Range(40, 80);
            changecount = 0;
        }
        float step = speed * Time.deltaTime;
        target.transform.position = new Vector3(x,y,z);
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        */

       
        if (Enemyhp == 0)
        {
            //enemyhp = -1;
            Instantiate(enemyDeath, this.transform.position, Quaternion.identity);
            StageManager.EnemyNum -= 1;
            Destroy(this.gameObject);
        }
        
        hpStatusUI.EnemyUpdateHPValue();
        RoopMove();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            Enemyhp -= 1;
        }    
    }
   
    public int EnemyHP()
    {
        return Enemyhp;
    }
    public int EnemyMaxHP()
    {
        return enemyMaxHP;
    }
    void RoopMove()
    {
        this.transform.position += new Vector3(move.x, move.y, move.z);
        if (directionx)
        {
            if (pos.x > movepos.x)
            {
                moveflagx = true;
            }
            if (pos.x < -movepos.x)
            {
                moveflagx = false;
            }

            if (moveflagx)
            {
                move.x = -speed;
            }
            else
            {
                move.x = speed;
            }
        }
        if (directionz)
        {
            if (pos.z >= movepos.z)
            {
                moveflagz = true;
            }
            if (pos.z <= -movepos.z)
            {
                moveflagz = false;
            }

            if (moveflagz)
            {
                move.z = -speed;
            }
            else
            {
                move.z = speed;
            }
        }
    }
}
