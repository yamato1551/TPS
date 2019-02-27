using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIChange : MonoBehaviour
{
    public Text start;
    public Text Enemys;
    private float alpha;
    private float count;
    private bool act;
    // Start is called before the first frame update
    void Start()
    {
        alpha = 1;
        act = false;
        //start = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //startui();
        count += 1;
        start.color = new Color(1f, 1f, 1f, alpha);
        if (count % 70 == 0)
        {
            act = true;
        }
        if (act == true)
        {
            alpha -= 0.1f;
        }
        if (alpha <= 0)
        {
            start.enabled = false;
            StageManager.pause = true;
        }

        Enemys.text = "Enemy:" + StageManager.EnemyNum;

    }
 
}
