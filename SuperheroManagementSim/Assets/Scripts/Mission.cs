using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission : MonoBehaviour {

    private readonly int Level;

    private List<int> Rewards;

    public string Name { get; set; }
    public string Description { get; set; }

    public Mission(int level, string name, string description, List<int> rewards)
    {
        Level = level;
        Name = name;
        Description = Description;
        Rewards = rewards;
    }
}
