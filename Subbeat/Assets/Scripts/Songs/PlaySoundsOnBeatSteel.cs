using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundsOnBeatSteel : MonoBehaviour {
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
            ResourceGeneration.steel = ResourceGeneration.steel + ResourceGeneration.steelGeneration;
            //Debug.Log("How much steel you have: " + ResourceGeneration.steel);


        }
    }
}
