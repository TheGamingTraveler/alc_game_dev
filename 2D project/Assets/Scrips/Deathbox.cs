using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathbox : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D other){

        if(other.name == "PC"){

            Debug.Log("player enters death zone");
            Destroy(other);
        }
		
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
