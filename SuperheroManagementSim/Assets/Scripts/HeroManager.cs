using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HeroManager
{

    //keep list of heros and generates new heros

    private List<Hero> masterHeroList;
    private List<Hero> activeHeroList;

    //Full constructor
    public HeroManager()
    {
        masterHeroList = new List<Hero>();
        activeHeroList = new List<Hero>();
    }

    //generate new hero
    public Hero generateHero() { return new Hero(); }

    //add hero to list
    //remove hero from list

    new Hero testHero = new Hero(1, 0, "Gary Lucas", "25", "Male", new List<string>());

}