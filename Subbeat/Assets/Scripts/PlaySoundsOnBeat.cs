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
	void Update ()
    {
        if(BPerM.beatFull)
        {
            //soundManager.PlaySound(wood, 1);
            ResourceGeneration.wood = ResourceGeneration.wood + ResourceGeneration.woodGeneration;
            //Debug.Log("How much wood you have: " + ResourceGeneration.wood);

            if (StoneUpgrades.stoneUpgrade1Obtained.Equals(true))
            {
                ResourceGeneration.stone = ResourceGeneration.stone + ResourceGeneration.stoneGeneration;
                //Debug.Log("How much stone you have: " + ResourceGeneration.stone);
            }

            if (CopperUpgrades.copperUpgrade1Obtained.Equals(true))
            {
                ResourceGeneration.copper = ResourceGeneration.copper + ResourceGeneration.copperGeneration;
            }

            if(IronUpgrades.ironUpgrade1Obtained.Equals(true))
            {
                ResourceGeneration.iron = ResourceGeneration.iron + ResourceGeneration.ironGeneration;
            }

            if(ForgeUpgrades.forgeUpgrade1Obtained.Equals(true))
            {
                ResourceGeneration.steel = ResourceGeneration.steel + ResourceGeneration.steelGeneration;
            }

            if(GoldUpgrades.goldUpgrade1Obtained.Equals(true))
            {
                ResourceGeneration.gold = ResourceGeneration.gold + ResourceGeneration.goldGeneration;
            }

            if(DiamondUpgrades.diamondUpgrade1Obtained.Equals(true))
            {
                ResourceGeneration.diamond = ResourceGeneration.diamond + ResourceGeneration.diamondGeneration;
            }


        }

        if(BPerM.beatD8 && BPerM.beatCountD8 % 2 == 0)
        {
            soundManager.PlaySound(stone, 1);

        }

    }
}
