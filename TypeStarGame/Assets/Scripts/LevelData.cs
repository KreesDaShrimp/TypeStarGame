using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LevelData {

    private static int level;

    public static void SetLevel(int newLevel)
    {
        level = newLevel;
    }
    public static int GetLevel()
    {
        return level;
    }
}
