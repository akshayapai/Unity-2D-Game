using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DinoTitleScript : MonoBehaviour
{
    public void startDinoGame()
    {
        SceneManager.LoadScene("Dino");
    }

    public void ExitDinoGame()
    {
        SceneManager.LoadScene("MainScreen");
    }
}
