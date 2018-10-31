using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionButton : MonoBehaviour {

    public Mission mission;

    public Text missionNameDisplay;
    public Text levelDisplay;

    public void Setup(Mission mission)
    {
        this.mission = mission;
        missionNameDisplay.text = mission.name;
        levelDisplay.text = mission.level.ToString();
    }
}
