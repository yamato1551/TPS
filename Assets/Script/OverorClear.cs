using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OverorClear : MonoBehaviour
{
    public AudioClip Over,Clear;
    private AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = gameObject.GetComponent<AudioSource>();
        if (StageManager.Result)
        {
            audiosource.clip = Clear;
            this.GetComponent<Text>().text = "GameClear";
        }
        else
        {
            audiosource.clip = Over;
            this.GetComponent<Text>().text = "GameOver";
        }
        audiosource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
