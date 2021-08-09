using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLevels : MonoBehaviour
{
    private GameObject menuCanvas;
    private GameObject levelsCanvas;
    private GameObject[] gameObjects;

    private void Start()
    {
        menuCanvas = GameObject.Find("MenuCanvas");
        gameObjects = Resources.FindObjectsOfTypeAll<GameObject>();
        foreach (GameObject i in gameObjects)
        {
            if (i.name == "LevelsCanvas")
            {
                levelsCanvas = i;
            }
        }
    }

    public void OnClickMenuLevel()
    {
        menuCanvas.SetActive(false);
        levelsCanvas.SetActive(true);
    }

    public void OnClickBack()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            levelsCanvas.SetActive(false);
            menuCanvas.SetActive(true);
        }
    }
}
