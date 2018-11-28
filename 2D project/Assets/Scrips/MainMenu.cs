using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public int LevelToLoad;

    public void LoadLevel(){
        SceneManager.LoadScene(LevelToLoad);
    }

    public void LevelExit(){
        Application.Quit();
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
