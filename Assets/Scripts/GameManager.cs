using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int bricksOnLevel;

    public int GetBricksOnLevel()
    {
        return bricksOnLevel;
    }

    public void SetBricksOnLevel(int brick)
    {
        bricksOnLevel--;
    }
}
