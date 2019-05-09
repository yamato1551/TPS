using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabEnemyTarget : MonoBehaviour
{
    private GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Player.transform.position - this.transform.position;
        Quaternion rotation = Quaternion.LookRotation(pos);
        transform.rotation = Quaternion.Slerp(this.transform.rotation, rotation, 1);
    }
}
