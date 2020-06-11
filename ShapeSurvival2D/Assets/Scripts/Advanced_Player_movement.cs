﻿
using UnityEngine;

public class Advanced_Player_movement : MonoBehaviour
{
        public float moveSpeed = 5f;

        public float jump_force = 5f;


        public bool is_grounded = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),0f,0f);

        transform.position += movement * Time.deltaTime * moveSpeed;
    }


    void jump(){

        if (Input.GetKey("space") && is_grounded == true){
        
        

        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f,jump_force),ForceMode2D.Impulse);
        }
    }
}