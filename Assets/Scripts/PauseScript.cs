using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuPrefab;

    public void OnClickPause()
    {
        PauseGame();
        pauseMenuPrefab.SetActive(true);
    }

    private void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void OnClickContinue()
    {
        pauseMenuPrefab.SetActive(false);
        Time.timeScale = 1;
    }

    public void OnClickReset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
}
