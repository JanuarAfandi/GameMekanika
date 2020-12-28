using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasMenu : MonoBehaviour
{
    public static bool isPause;
    public GameObject panelWin, panelLose, panelPause;
    void Start()
    {
        isPause = false;
        Time.timeScale = 1f;
        panelWin.SetActive(false);
        panelLose.SetActive(false);
        panelPause.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (WinLoseCondition.lose)
        {
            Time.timeScale = 0f;
            panelLose.SetActive(true);
        }

        if (WinLoseCondition.win)
        {
            Time.timeScale = 0f;
            panelWin.SetActive(true);
        }
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        panelWin.SetActive(false);
        panelLose.SetActive(false);
        SceneManager.LoadScene("InGame");
    }

    public void Exit()
    {
        Time.timeScale = 1f;
        panelWin.SetActive(false);
        panelLose.SetActive(false);
        SceneManager.LoadScene("MainMenu");
    }

    public void Pause()
    {
        isPause = true;
        panelPause.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        isPause = false;
        panelPause.SetActive(false);
        Time.timeScale = 1f;
    }
}
