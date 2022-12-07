using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectBall : MonoBehaviour
{
    [SerializeField] GameObject menuGameOver;
    void Start(){
        menuGameOver.SetActive(false);
    }
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.name == "ball"){
            menuGameOver.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
