using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
public class ScoreController
{
    public static int Score;
    public delegate void Notify();
    public static event Notify ScoreIncreased;

    public static void IncreaseScore(int amount)
    {
        Score += amount;
        ScoreIncreased?.Invoke();
    }
}
