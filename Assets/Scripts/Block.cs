using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    GameObject gameManagerObj;

    GameManager gameManager;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManagerObj = GameObject.Find("GameManager");
        gameManager = gameManagerObj.GetComponent<GameManager>();
        gameManager.SetBricksOnLevel(1);
        Destroy (gameObject);
    }
}
