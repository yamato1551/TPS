using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public int playerMaxHP;
    private int Playerhp;
    private PlayerHPStatusUI hpStatusUI;
    // Start is called before the first frame update
    void Start()
    {
        Playerhp = playerMaxHP;
        hpStatusUI = GameObject.Find("Canvas").GetComponent<PlayerHPStatusUI>();
    }

    // Update is called once per frame
    void Update()
    {
        hpStatusUI.PlayerUpdateHPValue();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "EnemyBullet")
        {
            Playerhp -= 1;
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

}
