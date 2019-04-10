using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundsOnBeatIron : MonoBehaviour {

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
            ResourceGeneration.iron = ResourceGeneration.iron + ResourceGeneration.ironGeneration;
            Debug.Log("How much iron you have: " + ResourceGeneration.iron);


        }
    }
}