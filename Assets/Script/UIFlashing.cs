using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFlashing : MonoBehaviour
{
    private Text tex;
    private float alpha=0;
    public bool blend = true;
    // Start is called before the first frame update
    void Start()
    {
        tex = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        tex.color = new Color(1f, 1f, 1f, alpha);
        if (alpha <= 0)
        {
            blend = true;
        }
        if (alpha >= 1)
        {
            blend = false;
        }

        if (blend)
        {
           alpha += Time.deltaTime * 0.7f;
        }
        else
        { 
            alpha -= Time.deltaTime * 0.7f;
        }
    }
}
