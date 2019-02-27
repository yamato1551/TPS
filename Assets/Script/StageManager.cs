using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StageManager : MonoBehaviour
{
    static public bool[] Stage=new bool[3];
    static public bool Result;
    static public int EnemyNum;
    static public bool pause;
    // Start is called before the first frame update
    void Start()
    {
        Stageflag();
        cursor();
        pause = false;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void Stageflag()
    {
        if (SceneManager.GetActiveScene().name == "Stage1")
        {
            Stage[0] = true;
            Stage[1] = false;
            Stage[2] = false;
        }
        if (SceneManager.GetActiveScene().name == "Stage2")
        {
            Stage[0] = false;
            Stage[1] = true;
            Stage[2] = false;
        }
        if (SceneManager.GetActiveScene().name == "Stage3")
        {
            Stage[0] = false;
            Stage[1] = false;
            Stage[2] = true;
        }
    }
    void cursor()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        if (SceneManager.GetActiveScene().name=="Stage1"||
            SceneManager.GetActiveScene().name == "Stage2"||
            SceneManager.GetActiveScene().name == "Stage3")
        {

            Cursor.lockState = CursorLockMode.Locked;

            Cursor.visible = false;
        }
    }
}
