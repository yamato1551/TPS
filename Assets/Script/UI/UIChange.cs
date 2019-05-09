using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIChange : MonoBehaviour
{
    public GameObject Panel;
    public Text start;
    public Text Condition;
    public Text Enemys;
    public string ConditionText;
    private float alpha,PanelAlpha,count;
    private bool act;
    bool stop=true;
    // Start is called before the first frame update
    void Start()
    {
        Condition.text = ConditionText;
        alpha = 1;
        PanelAlpha = 100;
        act = false;
        //start = GetComponent<Text>();
        //Condition = GetComponent<Text>();
       
    }


    // Update is called once per frame
    void Update()
    {
        if (stop == true)
        {
            //startui();
            count += 1;
            start.color = new Color(1f, 1f, 1f, alpha);
            Condition.color = new Color(1f, 1f, 1f, alpha);
            Panel.GetComponent<Image>().color = new Color(1f,1f,1f, PanelAlpha / 255f);

            if (count % 70 == 0)
            {
                act = true;
            }
            if (act == true)
            {
                alpha -= 0.1f;
                PanelAlpha -= 10f;
            }
            if (alpha <= 0)
            {
                //start.enabled = false;
                Destroy(Panel);
                StageManager.pause = true;
                stop = false;
            }
        }
        Enemys.text = "Enemy:" + StageManager.EnemyNum;

    }
 
}
