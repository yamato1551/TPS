using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI2 : MonoBehaviour
{
    [SerializeField]
    private GameObject Player;
    private EnemyShotShell enemyshotshell;
    private Vector3 move;
    public GameObject target;
    public Vector3 RandomMovePoint;
    public float speed=1;
    private int count = 0;
    void Start()
    {
        enemyshotshell = GetComponentInChildren<EnemyShotShell>();
        Player = GameObject.Find("Player");

    }

    void FixedUpdate()
    {
        
        if (StageManager.pause)
        {
            if (enemyshotshell.shotflag)
            {
                count++;
                if (count % 100 == 0)
                {
                    float min = Random.Range(-30, -50);
                    float max = Random.Range(30, 50);
                    RandomMovePoint.x = Random.Range(min, max);
                    RandomMovePoint.z = Random.Range(min, max);
                }

                float step = speed * Time.deltaTime;
                Vector3 playerpos = Player.transform.position;
                this.gameObject.transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
                target.transform.position = new Vector3(playerpos.x + RandomMovePoint.x, 5, playerpos.z + RandomMovePoint.z);

            }
        }
    }
}
