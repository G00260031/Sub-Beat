using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundsOnBeat : MonoBehaviour {
    public SoundManager soundManager;
    public AudioClip wood;
    public AudioClip stone;
    


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(BPerM.beatFull)
        {
            soundManager.PlaySound(wood, 1);
            ResourceGeneration.wood = ResourceGeneration.wood + ResourceGeneration.woodGeneration;
            Debug.Log("How much wood you have: " + ResourceGeneration.wood);
            if (StoneUpgrades.stoneUpgrade1Obtained.Equals(true))
            {
                ResourceGeneration.stone = ResourceGeneration.stone + ResourceGeneration.woodGeneration;
                Debug.Log("How much stone you have: " + ResourceGeneration.stone);
            }

        }

        if(BPerM.beatD8 && BPerM.beatCountD8 % 2 == 0)
        {
            soundManager.PlaySound(stone, 1);

        }

    }
}
