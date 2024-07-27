using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScript : MonoBehaviour
{
    public void LaunchFlappyBird()
    {
        SceneManager.LoadScene("Title_FlappyBird");
    }

    public void LaunchDinoGame()
    {
        SceneManager.LoadScene("Title_Dino");
    }

    public void LaunchSnake()
    {
        SceneManager.LoadScene("Title_Snake");
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
