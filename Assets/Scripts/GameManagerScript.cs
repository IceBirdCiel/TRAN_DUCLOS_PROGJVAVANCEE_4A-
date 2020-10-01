using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    [SerializeField]
    private ScoreTextScript score;

    [SerializeField]
    private string GameOverScreen;

    [SerializeField]
    private string VictoryScreen;

    [SerializeField]
    private TimerScript timer;

    [SerializeField]
    private int palier;

    // Update is called once per frame
    void Update()
    {
        if (timer.timeleft < 0)
        {
            timer.timeleft = 0;
            if (score.score.score < palier)
            {;
                GameOver();
            }
            else if (score.score.score >= palier)
            {
                Victory();
            }
        }
    }

    void GameOver()
    {
        Debug.Log("Game Over");
        //SceneManager.LoadScene(GameOverScreen);
    }

    void Victory()
    {
        Debug.Log("Victory !");
        //SceneManager.LoadScene(VictoryScreen);
    }
}
