using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnakeTitleScript : MonoBehaviour
{
    public void startSnakeGame()
    {
        SceneManager.LoadScene("Snake");
    }

    public void ExitSnakeGame()
    {
        SceneManager.LoadScene("MainScreen");
    }
}
