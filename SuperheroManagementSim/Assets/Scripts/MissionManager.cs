using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionManager {

    //Lists to keep track of missions
    private List<Mission> ActiveMissions;
    private List<Mission> AvailableMissions;
    private List<Mission> CompletedMissions;



    //Full Constructor
    public MissionManager()
    {
        ActiveMissions = new List<Mission>();
        AvailableMissions = new List<Mission>();
        CompletedMissions = new List<Mission>();
    }

    //Generate a new mission
    public void generateMission()
    {
        Mission newMission = new Mission();
    }

    new Mission testMission = new Mission(1, 1, "Fuck yea", "Gary sux", new List<int>());
}
