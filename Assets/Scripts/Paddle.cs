using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    int speed = 12;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)){
            this.transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.D)){
            this.transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision){
        Debug.Log(collision.gameObject.name);
    }
}
