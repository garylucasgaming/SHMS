using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundManager : MonoBehaviour{

    public static SoundManager instance = null;

    void Awake()
    {
        //check if instance exists
        if (instance == null)
            //if not, set instance to this
            instance = this;
        //if instance exists, and its not this
        else if (instance != this)
            //destroy this, enforcing singleton
            Destroy(gameObject);

        //set this to not be destroyed when reloading
        DontDestroyOnLoad(gameObject);

        

    }

}