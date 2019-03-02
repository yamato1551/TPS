using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerStatus : MonoBehaviour
{
    public int playerMaxHP;
    public int Playerhp;
    private PlayerHPStatusUI hpStatusUI;
    private SwitchScene swis;
    public bool isDamage = false;
    //private GameObject enemybullet;
    // Start is called before the first frame update
    void Start()
    {
        Playerhp = playerMaxHP;
        hpStatusUI = GameObject.Find("Canvas").GetComponent<PlayerHPStatusUI>();
        swis = GameObject.Find("Directional Light").GetComponent<SwitchScene>();
      }

    // Update is called once per frame
    void Update()
    {
        //enemybullet = GameObject.Find("EnemyBullet");
        this.gameObject.GetComponent<Renderer>().material.color = new Color32(58, 103, 152, 1);
        hpStatusUI.PlayerUpdateHPValue();
        if (Playerhp <= 0)
        {
            swis.GameOver();
        }
        if (isDamage)
        {
            this.gameObject.GetComponent<Renderer>().material.color = new Color32(58, 0, 152, 1);
            Invoke("flagDeray",0.03f);
        }
    }
    void OnTriggerEnter(Collider collision)
    {
       if (collision.gameObject.tag == "GameOverArea")
        {
            swis.GameOver();
        }
       
    }
    public int PlayerHP()
    {
        return Playerhp;
    }
    public int PlayerMaxHP()
    {
        return playerMaxHP;
    }
    void flagDeray()
    {
        isDamage = false;
    }

}
