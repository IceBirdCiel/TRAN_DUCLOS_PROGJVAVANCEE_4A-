using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Score
{
    public int score;

    public Score(int score)
    {
        this.score = score;
    }

    public Score()
    {
        score = 0;
    }

    public void AugmenterScore(int value)
    {
        score += value;
    }
}
