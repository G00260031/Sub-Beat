using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundsOnBeatStone : MonoBehaviour {
    public SoundManager soundManager;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(BPerM.beatFull)
        {
            ResourceGeneration.stone = ResourceGeneration.stone + ResourceGeneration.stoneGeneration;
            Debug.Log("How much stone you have: " + ResourceGeneration.stone);

          
        }
    }
}
