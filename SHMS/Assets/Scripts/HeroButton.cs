using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroButton : MonoBehaviour {

    public Hero hero;

    public Text heroNameDisplay;
    public Text levelDisplay;

    public void Setup(Hero hero)
    {
        this.hero = hero;
        heroNameDisplay.text = hero.name;
        levelDisplay.text = hero.level.ToString();
    }
}
