using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHPStatusUI : MonoBehaviour
{
    private PlayerStatus playerstatus;
    private Slider hpSlider;
    // Start is called before the first frame update
    void Start()
    {
        playerstatus = GameObject.Find("Player").GetComponent<PlayerStatus>();
        hpSlider = transform.Find("PlayerHPBar").GetComponent<Slider>();
        hpSlider.value = (float)playerstatus.PlayerMaxHP()/(float)playerstatus.PlayerMaxHP();
    }

    // Update is called once per frame
    void Update()
    {
       }
    public void PlayerUpdateHPValue()
    {
        hpSlider.value = (float)playerstatus.PlayerHP() / (float)playerstatus.PlayerMaxHP();
    }
}
