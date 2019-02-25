using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerStatus : MonoBehaviour
{
    public int playerMaxHP;
    private int Playerhp;
    private PlayerHPStatusUI hpStatusUI;
    private SwitchScene swis;
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
        hpStatusUI.PlayerUpdateHPValue();
        if (Playerhp <= 0)
        {
            swis.GameOver();
        }
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
