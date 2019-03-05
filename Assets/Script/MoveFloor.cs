using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloor : MonoBehaviour
{
    public float distance;
    public float speed;
    public bool moveflagx, moveflagy, moveflagz;
    private Vector3 initialPosition;
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
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

    }
    private void OnCollisionEnter(Collision collision)
    {
        //触れているオブジェクトを子オブジェクトにする
        collision.gameObject.transform.SetParent(this.transform);
    }
    private void OnCollisionExit(Collision collision)
    {
        //子オブジェクトをnullにする
        collision.gameObject.transform.SetParent(null);
    }
}
