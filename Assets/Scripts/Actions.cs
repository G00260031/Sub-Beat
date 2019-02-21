using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Actions : MonoBehaviour
{
    public void GameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    /*
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void UpgradeMenu()
    {
        SceneManager.LoadScene("UpgradeMenu");
    }

    public void Music()
    {
        SceneManager.LoadScene("Music");
    }
    */

}
