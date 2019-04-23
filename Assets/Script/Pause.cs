using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField]
    private GameObject pauseUIPrefab;
    private GameObject pauseUIInstance;
    void Update()
    {
        if (StageManager.pause==true) {
            if (Input.GetKeyDown("q"))
            {
                if (pauseUIInstance == null)
                {
                    pauseUIInstance = GameObject.Instantiate(pauseUIPrefab) as GameObject;
                    Time.timeScale = 0f;
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                    StageManager.pause = false;
                }
            }
        }
    }
}
