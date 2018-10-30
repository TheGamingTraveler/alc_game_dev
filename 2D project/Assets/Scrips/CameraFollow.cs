using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public CharMove PC;

    public bool isFollowing;

    //Camera Position offset
    public float xOffset;

    public float yOffset;

	// Use this for initialization
	void Start () {
        PC = FindObjectOfType<CharMove>();

        isFollowing = true;
        
	}
	
	// Update is called once per frame
	void Update () {
        if(isFollowing){
            transform.position = new Vector3(PC.transform.position.x + xOffset, PC.transform.position.y + yOffset, transform.position.z);
        }
		
	}
}
