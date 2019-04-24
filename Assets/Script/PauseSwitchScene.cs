using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseSwitchScene : MonoBehaviour
{
    public void BackGame()
    {
        Destroy(this.gameObject);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        StageManager.pause = true;
    }
    public void StageSelect()
    {
        SceneManager.LoadScene("StageSelect");
    }
    public void Retry()
    {
        if (StageManager.Stage[0] == true)
        {
            StageManager.EnemyNum = 0;
            SceneManager.LoadScene("Stage1");
        }
        if (StageManager.Stage[1] == true)
        { 
            StageManager.EnemyNum = 0;
            SceneManager.LoadScene("Stage2");
        }
        if (StageManager.Stage[2] == true)
        {
            StageManager.EnemyNum = 0;
            SceneManager.LoadScene("Stage3");
        }
    }
}