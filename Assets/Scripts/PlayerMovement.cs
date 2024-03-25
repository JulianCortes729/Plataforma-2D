using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private float forceJump;

    private Rigidbody2D playerRb;

    void Start(){
        playerRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Walk();
        Jump();
    }

    void Walk(){
        float moveH = Input.GetAxis("Horizontal");
        playerRb.velocity = new Vector2(moveH * speed , playerRb.velocity.y);
    }

    void Jump(){
        if(Input.GetKeyDown(KeyCode.Space)){
            playerRb.velocity = new Vector2(0, forceJump);
        }
        
    }
}
