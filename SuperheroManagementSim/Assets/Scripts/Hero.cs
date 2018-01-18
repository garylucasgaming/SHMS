using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {

    private int level, experience;

    private List<string> Powers;

    private bool onDuty = false;

    private string name, age, gender;

    public Hero(int level, int experience, string name, string age, string gender, List<string> powers)
    {
        this.level = level;
        this.experience = experience;
        this.name = name;
        this.age = age;
        this.gender = gender;
        Powers = Powers;
    }
    
}
