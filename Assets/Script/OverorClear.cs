using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OverorClear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (StageManager.Result)
        {
            this.GetComponent<Text>().text = "GameClear";
        }
        else
        {
            this.GetComponent<Text>().text = "GameOver";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
