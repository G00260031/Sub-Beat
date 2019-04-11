using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Actions : MonoBehaviour
{
    public Image black;
    public Animator anim;

    public void GameScene()
    {
        SceneManager.LoadScene("GameScene");
        anim.enabled = true;
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
