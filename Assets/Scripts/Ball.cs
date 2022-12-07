using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidBody2D;
    Vector2 moveDirection;
    Vector2 currentVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D.velocity = Vector2.up * 5;
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void FixedUpdate(){
        currentVelocity = rigidBody2D.velocity;
    }
    private void OnCollisionEnter2D(Collision2D collision){
        moveDirection = Vector2.Reflect(currentVelocity, collision.GetContact(0).normal);
        rigidBody2D.velocity = moveDirection;
        
    }
}
