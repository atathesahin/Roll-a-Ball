using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void PLayGame()
    {
        SceneManager.LoadScene("Scene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
