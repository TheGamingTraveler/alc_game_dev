using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charmove : MonoBehaviour {

    // Player Movement Variables
    public int MoveSpeed;
    public float jumpheight;

    // Player grounded variables
    public Transform groundcheck;
    public float groundCheckRadius;
    public LayerMask whatisground;
    private bool grounded;

	// Use this for initialization
	void Start () {
		
	}


	private void FixedUpdate () {
        grounded = Physics2D.OverlapCircle(groundcheck.position, groundCheckRadius, whatisground)
	}


	// Update is called once per frame
	void Update () {

        //this code makes the character jump
        if(Input.GetKeyDown (KeyCode.Space)&& grounded)
            Jump();
	}


    public void Jump(){
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpheight);
    }
}
