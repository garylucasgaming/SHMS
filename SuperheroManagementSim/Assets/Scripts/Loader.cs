using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour {

    //prefabs to instatiate
    public GameObject gameManager; 
    public GameObject soundManager;

	
	void Awake () {

        //check if GameManager has already been assigned to Gamemanager.instance, if null instantiate
        if (GameManager.instance == null)
            Instantiate(gameManager);

        if (SoundManager.instance == null)
            Instantiate(soundManager);


    }
	
}
