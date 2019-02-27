using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    float count;
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Title")
        {
            if (Input.anyKey)
            {
                SceneManager.LoadScene("StageSelect");
            }
        }
        GameClear();
    }
    public void Stage1()
    {
        SceneManager.LoadScene("Stage1");
    }
    public void Stage2()
    {
        SceneManager.LoadScene("Stage2");
    }
    public void Stage3()
    {
        SceneManager.LoadScene("Stage3");
    }
    public void StageSelect()
    {
        SceneManager.LoadScene("StageSelect");
    }
    public void NextStage()
    {
        if (StageManager.Stage[0] == true)
        {
            SceneManager.LoadScene("Stage2");
        }
        if (StageManager.Stage[1] == true)
        {
            SceneManager.LoadScene("Stage3");
        }
       
    }
    public void Retry()
    {
        if (StageManager.Stage[0] == true)
        {
            SceneManager.LoadScene("Stage1");
        }
        if (StageManager.Stage[1] == true)
        {
            SceneManager.LoadScene("Stage2");
        }
        if (StageManager.Stage[2] == true)
        {
            SceneManager.LoadScene("Stage3");
        }
    }
    public void GameOver()
    {
        SceneManager.LoadScene("Result");
        StageManager.Result = false;
    }
    public void GameClear()
    {
        if (SceneManager.GetActiveScene().name == "Stage1" ||
            SceneManager.GetActiveScene().name == "Stage2" ||
            SceneManager.GetActiveScene().name == "Stage3")
        {
            if (StageManager.EnemyNum <= 0)
            {
                count += 1;
                if (count % 100f == 0)
                    SceneManager.LoadScene("Result");
                StageManager.Result = true;
            }
        }
    }

}
