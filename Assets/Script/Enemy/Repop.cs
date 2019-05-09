using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repop : MonoBehaviour
{
    [SerializeField]
    private GameObject EnemyPrefab;
    private GameObject EnemyPrefabInstance;
    private int count;
    private Vector3 pos;
    void Start()
    {
        EnemyPrefabInstance = GameObject.Instantiate(EnemyPrefab) as GameObject;
        EnemyPrefabInstance.transform.position = this.gameObject.transform.position;
    }
    void FixedUpdate()
    {
        pos.x = Random.Range(-45, 45);
        pos.y = 2.89f;
        pos.z = Random.Range(30, 130);
        count++;
        if (count % 200 == 0)
        {
            this.gameObject.transform.position = new Vector3(pos.x, pos.y, pos.z);

            if (EnemyPrefabInstance == null)
            {
                EnemyPrefabInstance = GameObject.Instantiate(EnemyPrefab) as GameObject;
                EnemyPrefabInstance.transform.position = this.gameObject.transform.position;
            }
        }
    }
}
