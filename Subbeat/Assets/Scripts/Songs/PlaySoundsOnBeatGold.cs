using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundsOnBeatGold : MonoBehaviour {
    public SoundManager soundManager;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (BPerM.beatFull)
        {
            ResourceGeneration.gold = ResourceGeneration.gold + ResourceGeneration.goldGeneration;
            Debug.Log("How much gold you have: " + ResourceGeneration.gold);


        }
    }
}
