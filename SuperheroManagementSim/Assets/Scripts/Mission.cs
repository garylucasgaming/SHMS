using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission : MonoBehaviour {

    private readonly int Level;

    private readonly int CompletionTime;

    private List<int> Rewards;

    private readonly int HeroCapacity;

    public string Name { get; set; }
    public string Description { get; set; }

    public Mission(int level, int completionTime, int heroCapacity, string name, string description, List<int> rewards)
    {
        Level = level;
        CompletionTime = completionTime;
        HeroCapacity = heroCapacity;
        Name = name;
        Description = Description;
        Rewards = rewards;
    }

    //Default Constructor
    public Mission() { }

    public int getHeroCapacity()
    {
        return HeroCapacity;
    }

}
