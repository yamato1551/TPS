using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSE : MonoBehaviour
{
    public AudioClip footSE;
    private AudioSource audiosouce;
    // Start is called before the first frame update
    void Start()
    {
        audiosouce = gameObject.GetComponent<AudioSource>();
    }
    public void footse()
    {
        audiosouce.clip = footSE;
        audiosouce.Play();
    }
}
