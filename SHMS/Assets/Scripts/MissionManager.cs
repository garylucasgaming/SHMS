using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionManager : MonoBehaviour {

    public List<Mission> availableMissions;
    public Dictionary<Mission, Hero[]> activeMissions;

    public float baseMissionSuccess = 0.95f;
    public float missionLevelMod = 0.8f;
    public float levelAddition = 0.05f;

    public void AssignHeroToMission(Hero hero, Mission mission)
    {
        //If the mission doesn't exist in the activeMissions, add it and the hero to it
        if (!activeMissions.ContainsKey(mission))
        {
            MakeMissionActive(mission);
            activeMissions[mission][0] = hero;
        }

        //Find an empty slot for the hero and place it
        for (int i = 0; i < activeMissions[mission].Length; i++)
        {
            Hero heroSlot = activeMissions[mission][i];

            if (heroSlot == null)
            {
                heroSlot = hero;
            }
        }
    }

    public void MakeMissionActive(Mission mission)
    {
        Hero[] assignedHeroes = new Hero[mission.maxAssignableHeroes];
        activeMissions.Add(mission, assignedHeroes);
    }

    public bool ResolveMission(Mission toResolve, Hero[] assignedHeroes)
    {
        int netHeroLevel = CalculateNetHeroLevel(toResolve, assignedHeroes);

        float successChance = CalculateSuccessChance(toResolve, netHeroLevel);

        if (successChance >= 1)
        {
            return true;
        }

        float result = Random.Range(0, 1);

        if (result <= successChance)
        {
            return true;
        }
        else return false;
    }

    public int CalculateNetHeroLevel(Mission mission, Hero[] heroes)
    {
        int netHeroLevel = -mission.level;

        for (int i = 0; i < heroes.Length; i++)
        {
            netHeroLevel += heroes[i].level;
        }

        return netHeroLevel;
    }

    public float CalculateSuccessChance(Mission mission, int netHeroLevel)
    {
        float successChance = baseMissionSuccess * Mathf.Pow(missionLevelMod, mission.level - 1);
        float successChanceMod = 1 + levelAddition * netHeroLevel;
        successChance *= successChanceMod;

        return successChance;
    }

}
