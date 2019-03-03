using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyHPStatusUI : MonoBehaviour
{
    private EnemyAI enemyAI;
    private Slider hpSlider;

    // Start is called before the first frame update
    void Start()
    {
        enemyAI = transform.root.GetComponent<EnemyAI>();
        hpSlider = transform.Find("HPBar").GetComponent<Slider>();
        hpSlider.value = (float)enemyAI.EnemyMaxHP() / (float)enemyAI.EnemyMaxHP();
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Camera.main.transform.rotation;
    }

    public void EnemyUpdateHPValue()
    {
        hpSlider.value = (float)enemyAI.EnemyHP() / (float)enemyAI.EnemyMaxHP();
        //Debug.Log("Sliderupdate");
    }

}
