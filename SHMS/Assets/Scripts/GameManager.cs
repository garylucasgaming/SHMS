using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public MissionManager missionManager;
    public HeroManager heroManager;

    public int week;
    public Text weekDisplay;

    public Transform heroListView;
    public GameObject heroButtonPrefab;

    public Transform missionListView;
    public GameObject missionButtonPrefab;

    void Start()
    {
        weekDisplay.text = "Week " + week;

        foreach (Hero hero in heroManager.heroes)
        {
            GameObject newHeroButton = Instantiate(heroButtonPrefab);
            newHeroButton.transform.SetParent(heroListView);
            newHeroButton.GetComponent<HeroButton>().Setup(hero);
        }

        //foreach (Mission mission in missionManager.availableMissions)
        //{
        //    GameObject newMissionButton = Instantiate(missionButtonPrefab);
        //    newMissionButton.transform.SetParent(missionListView);
        //    newMissionButton.GetComponent<MissionButton>().Setup(mission);
        //}

    }



}
                                                                                                                                                                             