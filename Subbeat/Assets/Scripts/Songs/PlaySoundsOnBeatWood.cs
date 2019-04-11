using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundsOnBeatWood : MonoBehaviour {

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
            ResourceGeneration.wood = ResourceGeneration.wood + ResourceGeneration.woodGeneration;                  
            //Debug.Log("How much wood you have: " + ResourceGeneration.wood);    
        }
    }
}
