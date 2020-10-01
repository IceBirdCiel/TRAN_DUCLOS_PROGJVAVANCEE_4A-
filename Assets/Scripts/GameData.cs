using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Game Data", menuName = "GameData", order =51)]
public class GameData : ScriptableObject
{
    private bool isWinning;

    private int score;

    public bool IsWinning { get => isWinning; set => isWinning = value; }
    public int Score { get => score; set => score = value; }
}
