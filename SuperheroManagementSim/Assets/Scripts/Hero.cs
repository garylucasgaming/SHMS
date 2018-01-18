using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {

    //Hero information
    private int level, experience;

    //List of powers - to be used for missions
    private List<string> Powers;

    //Hero information - will be gen'd
    private string name, age, gender;

    //Full constructor
    public Hero(int level, int experience, string name, string age, string gender, List<string> powers)
    {
        this.level = level;
        this.experience = experience;
        this.name = name;
        this.age = age;
        this.gender = gender;
        Powers = powers;
    }

    //Default constructor
    public Hero()
    {

    }
}
