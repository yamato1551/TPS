using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyAI : MonoBehaviour
{
    //private Vector3 move;
    public int enemyMaxHP = 5;
    private int Enemyhp;
    public float speed;
    public float distance;
    public GameObject enemyDeath;
    private EnemyHPStatusUI hpStatusUI;
    //public float pos;
    //private Vector3 nowpos;
    //private Vector3 pos;
    //public Vector3 movepos;
    public bool directionx,directionz,moveflagx,moveflagy,moveflagz;
    private Vector3 initialPosition;
   // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
        StageManager.EnemyNum += 1;
        Enemyhp = enemyMaxHP;
        hpStatusUI = GetComponentInChildren<EnemyHPStatusUI>();
        #region
        /*
        pos = this.gameObject.transform.position;
        nowpos.x = pos.x;
        nowpos.y = pos.y;
        nowpos.z = pos.z;
        movepos.x = nowpos.x + movepos.x;
        movepos.y = nowpos.y + movepos.y;
        movepos.z = nowpos.z + movepos.z;
        */
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        #region
        /*
        pos = this.gameObject.transform.position;
        
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
        #endregion

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
        if (moveflagx)
        {
            transform.position = new Vector3(Mathf.Sin(Time.time * speed) * distance + initialPosition.x, initialPosition.y, initialPosition.z);
        }
        if (moveflagy)
        {
            transform.position = new Vector3(initialPosition.x, Mathf.Sin(Time.time * speed) * distance + initialPosition.y, initialPosition.z);
        }
        if (moveflagz)
        {
            transform.position = new Vector3(initialPosition.x, initialPosition.y, Mathf.Sin(Time.time * speed) * distance + initialPosition.z);
        }
        #region
        /*
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
        */
        #endregion
    }
}
