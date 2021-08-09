using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsManager : MonoBehaviour
{
    private string level;

    public void OnClickLevel()
    {
        level = gameObject.name;
        Time.timeScale = 1;
        SceneManager.LoadScene(Int32.Parse(level));
    }
}
