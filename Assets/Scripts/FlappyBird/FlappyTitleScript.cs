using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyTitleScript : MonoBehaviour
{
    public void startFlappyGame()
    {
        SceneManager.LoadScene("FlappyBird") ;
    }

    public void ExitFlappyBird()
    {
        SceneManager.LoadScene("MainScreen");
    }
}
