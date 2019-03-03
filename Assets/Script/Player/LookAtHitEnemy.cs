using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtHitEnemy : MonoBehaviour
{
    public Transform target, EnemyHitTarget;
    private HitCast hitcast;
    void Start()
    {
        hitcast = GameObject.Find("MainCamera").GetComponent<HitCast>();
    }
    
    void Update()
    {
        if (hitcast.hitflag)
        {
            transform.LookAt(EnemyHitTarget);
        }
        else
        {
            transform.LookAt(target);
        }
    }
}
