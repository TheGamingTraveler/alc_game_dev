using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public GameObject currentCheckPoint;

    private Rigidbody2D PC;

    // Particles

    public GameObject deathParticle;

    public GameObject respawnParticle;

    //Respawn Delay

    public float respawndelay;

    //point penalty on death

    public int pointPenaltyOnDeath;

    //store gravity value

    private float gravityStore;

	// Use this for initialization
	void Start () {
        PC = FindObjectOfType<Rigidbody2D>();
		
	}
	
    public void RespawnPlayer(){
        StartCoroutine("RespawnPlayerCo");
    }

    public IEnumerator RespawnPlayerCo(){
        //Generate Death Particle
        Instantiate(deathParticle, PC.transform.position, PC.transform.rotation);
        //gravity reset
        gravityStore = PC.GetComponent<Rigidbody2D>().gravityScale;
        PC.GetComponent<Rigidbody2D>().gravityScale = 0f;
        PC.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        //Point penalty
        ScoreManager.AddPoints(-pointPenaltyOnDeath);
        //Debug message
        Debug.Log("player Respawn");
        //respawn delay
        yield return new WaitForSeconds(respawndelay);
        //gravity restore
        PC.GetComponent<Rigidbody2D>().gravityScale = gravityStore;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
