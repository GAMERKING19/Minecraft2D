using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
   public Rigidbody2D rb;
   public float speed = 10.0f;

   public Vector2 movement;

  

   

   

  

  
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"));
        Vector2 Player_pos = transform.position;



       
        

 

        




 

        

        
        
    }

    void FixedUpdate(){
     Character_Movement(movement);
        
    }
 
    void Character_Movement(Vector2 direction){
        rb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));


    }
}
