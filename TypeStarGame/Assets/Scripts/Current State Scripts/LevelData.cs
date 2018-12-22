using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LevelData {

    private static int level;
    private static int shipsDestroyed;
    private static int score;
    private static int survivalTime;

    public static void SetLevel(int newLevel)
    {
        level = newLevel;
    }
    public static int GetLevel()
    {
        return level;
    }

    public static void IncrementNumDestroyed()
    {
        shipsDestroyed++;
    }
    public static void SetNumDestroyed(int destroyed)
    {
        shipsDestroyed = 0;
    }
    public static int GetNumDestroyed()
    {
        return shipsDestroyed;
    }

    public static void IncrementScore()
    {
        score++;
    }
    public static void SetScore(int newScore)
    {
        score = newScore;
    }
    public static int GetScore()
    {
        return score;
    }

    public static void IncrementTime()
    {
        survivalTime++;
    }
    public static void SetTime(int newTime)
    {
        survivalTime = newTime;
    }
    public static int GetTime()
    {
        return survivalTime;
    }
}
