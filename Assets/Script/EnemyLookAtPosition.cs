using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLookAtPosition : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = player.transform.position;

        this.gameObject.transform.position = new Vector3(pos.x, 1, pos.z);
    }
}
