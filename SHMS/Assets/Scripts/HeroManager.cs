using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class HeroManager : MonoBehaviour { 

    public List<Hero> heroes = new List<Hero>();

    public List<Hero> activeHeroes = new List<Hero>();

    public Hero selectedHero;

    public void SetSelectedHero(Hero hero)
    {
        selectedHero = hero;
    }

}

