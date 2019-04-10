using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundsOnBeatCopper : MonoBehaviour {

    public SoundManager soundManager;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(BPerM.beatFull)
        {
            ResourceGeneration.copper = ResourceGeneration.copper + ResourceGeneration.copperGeneration;
            Debug.Log("How much copper you have: " + ResourceGeneration.copper);
        }
    }
}
