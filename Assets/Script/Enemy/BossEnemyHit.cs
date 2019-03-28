using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnemyHit : MonoBehaviour
{
    private EnemyAI EA;
    void Start()
    {
        EA = GetComponentInParent<EnemyAI>();         
    }
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            EA.Enemyhp -= 1;
        }
    }
}
