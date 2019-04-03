using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointRotate : MonoBehaviour
{
    public float range;
    public float speed;
    private Vector3 initialPosition;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.localEulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(initialPosition.x, Mathf.Sin(Time.time * speed) * range + initialPosition.y,initialPosition.z);
    }
}
