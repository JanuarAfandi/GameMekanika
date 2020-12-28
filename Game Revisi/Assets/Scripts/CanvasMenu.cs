using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasMenu : MonoBehaviour
{
    public GameObject panelWin, panelLose;
    void Start()
    {
        Time.timeScale = 1f;
        panelWin.SetActive(false);
        panelLose.SetActive(false);
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

}
