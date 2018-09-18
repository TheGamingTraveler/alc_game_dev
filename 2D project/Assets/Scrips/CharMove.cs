using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMove : MonoBehaviour{
    
    // Player Movement Variables
    public int MoveSpeed;
    public float jumpheight;
    private bool doubleJump;

    // Player grounded variables
    public Transform groundcheck;
    public float groundCheckRadius;
    public LayerMask whatisground;
    private bool grounded;

    // Use this for initialization
    void Start () {

    }


     void FixedUpdate(){
       grounded = Physics2D.OverlapCircle(groundcheck.position, groundCheckRadius, whatisground);
    
    }

    // Update is called once per frame
    void Update()
    {
        //this code makes the character jump
        if (Input.GetKeyDown (KeyCode.Space)&& grounded){
            Jump();
        }

        //Double Jump code
        if(grounded)
            doubleJump = false;

        if (Input.GetKeyDown(KeyCode.Space) && !doubleJump && !grounded){
            Jump();
            doubleJump = true;

        }

        //this code makes the character move from side to side using the A&D keys
        if(Input.GetKey (KeyCode.D)){
            GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);

        }
        if(Input.GetKey (KeyCode.A)){
            GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
    }
    
}
    public void Jump(){
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpheight);
    }
}
