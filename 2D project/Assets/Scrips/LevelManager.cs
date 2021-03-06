﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public GameObject currentCheckPoint;
    public Rigidbody2D PC;
    public GameObject PC2;

    //Particles

    public GameObject respawnParticle;
    public GameObject deathParticle;

    //respawn delay
    public float respawndelay;

    //point penalty on death

    public int pointPenaltyOnDeath;

    //store gravity value

    private float gravityStore;

	// Use this for initialization
	void Start () {
        PC = GameObject.Find("PC").GetComponent<Rigidbody2D>();
        PC2 = GameObject.Find("PC");
		
	}

    public void RespawnPlayer(){
        StartCoroutine("RespawnPlayerCo");
    }

    public IEnumerator RespawnPlayerCo(){
        //Generate Death Particle
        Instantiate(deathParticle, PC.transform.position, PC.transform.rotation);
        //hide PC
        //PC.enabled = false;
        PC2.SetActive(false);
        PC.GetComponent<Renderer>().enabled = false;
        //Gravity Reset
        gravityStore = PC.GetComponent<Rigidbody2D>().gravityScale;
        PC.GetComponent<Rigidbody2D>().gravityScale = 0f;
        PC.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        //Point Penalty
        //ScoreManager.Addpoints(-pointPenaltyOnDeath);
        //Debug message
        Debug.Log("player Respawn");
        //debug delay
        yield return new WaitForSeconds(respawndelay);
        //gravity restore
        PC.GetComponent<Rigidbody2D>().gravityScale = gravityStore;
        //math PC transform position
        PC.transform.position = currentCheckPoint.transform.position;
        //show PC
        //PC.enable = true;
        PC2.SetActive(true);
        PC.GetComponent<Renderer>().enabled = true;
        //spawn PC
        Instantiate(respawnParticle, currentCheckPoint.transform.position, currentCheckPoint.transform.rotation);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
