using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySE : MonoBehaviour
{
    public AudioClip SE;
    private AudioSource audiosouce;
    // Start is called before the first frame update
    void Start()
    {
        audiosouce = gameObject.GetComponent<AudioSource>();
        audiosouce.clip = SE;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            audiosouce.Play();
        }
    }
}
