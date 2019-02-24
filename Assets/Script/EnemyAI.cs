using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyAI : MonoBehaviour
{
    float x, y, z;
    public Transform target;
    public float speed;
    public float changecount;
    public float count;
    public int enemyMaxHP = 5;
    private int Enemyhp;
    public GameObject enemyDeath;
    private EnemyHPStatusUI hpStatusUI;
    // Start is called before the first frame update
    void Start()
    {
        Enemyhp = enemyMaxHP;
        hpStatusUI = GetComponentInChildren<EnemyHPStatusUI>();
    }

    // Update is called once per frame
    void Update()
    {
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
        if (Enemyhp == 0)
        {
            //enemyhp = -1;
            Instantiate(enemyDeath, this.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
        hpStatusUI.EnemyUpdateHPValue();
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
}
