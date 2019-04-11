using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundsOnBeatDiamond : MonoBehaviour {
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
            ResourceGeneration.diamond = ResourceGeneration.diamond + ResourceGeneration.diamondGeneration;
            Debug.Log("How much diamond you have: " + ResourceGeneration.diamond);


        }
    }
}
