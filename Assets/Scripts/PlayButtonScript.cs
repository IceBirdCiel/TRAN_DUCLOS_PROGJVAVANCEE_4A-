using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void GameScreen()
    {
        SceneManager.LoadScene("GameScreen");
    }

    public void MenuScreen()
    {
        SceneManager.LoadScene("MainMenuScreen");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}