using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    //scene manager
    //save and load
    //player manager
    //gamestate
    //hero manager?
    //game stats(fame, money)


    private SceneManager sceneManager;
    private PlayerManager playerManager;
    private HeroManager heroManager;
    private SoundManager soundManager;
    private int fame;
    private int money;
    private enum GameState {MainMenu, Options, Game };
    private SaveManager saveManager;

    //singleton
    public static GameManager instance = null;

    //on open game 
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

        //initialize game through scenemanager

    }


}
