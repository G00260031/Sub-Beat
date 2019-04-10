using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoneUpgrades : MonoBehaviour {
    public static bool stoneStart = true;
    public static bool stoneUpgrade1 = false;
    public static bool stoneUpgrade1Obtained = true;
    public static bool stoneUpgrade2 = false;
    public static bool stoneUpgrade2Obtained = false;
    public static bool stoneUpgrade3 = false;
    public static bool stoneUpgrade4 = false;
    public static bool stoneUpgrade5 = false;

    // Use this for initialization
    void Start ()
    {
		
	}

    // Update is called once per frame
    void Update()
    {

    }

    public void stoneUpgrade()
    {
        if (stoneUpgrade5.Equals(true))
        {

        }
        else if (stoneUpgrade4.Equals(true))
        {
            if (ResourceGeneration.stone >= 5)
            {
                ResourceGeneration.stone = ResourceGeneration.stone - 5;
                ResourceGeneration.stoneGeneration = ResourceGeneration.stoneGeneration + 1;
                stoneUpgrade5.Equals(true);
                stoneUpgrade4.Equals(false);

            }
        }
        else if (stoneUpgrade3.Equals(true))
        {
            if (ResourceGeneration.stone >= 5)
            {
                ResourceGeneration.stone = ResourceGeneration.stone - 5;
                ResourceGeneration.stoneGeneration = ResourceGeneration.stoneGeneration + 1;
                stoneUpgrade4.Equals(true);
                stoneUpgrade3.Equals(false);
            }
        }
        else if (stoneUpgrade2.Equals(true))
        {
            if (ResourceGeneration.stone >= 5)
            {
                ResourceGeneration.stone = ResourceGeneration.stone - 5;
                ResourceGeneration.stoneGeneration = ResourceGeneration.stoneGeneration + 1;
                stoneUpgrade3.Equals(true);
                stoneUpgrade2.Equals(false);
            }
        }
        else if (ResourceGeneration.stone >= 5 && stoneStart.Equals(true))
        {
            ResourceGeneration.stone = ResourceGeneration.stone - 5;
            ResourceGeneration.stoneGeneration = ResourceGeneration.stoneGeneration + 1;
            stoneUpgrade2.Equals(true);
            stoneStart.Equals(false);
        }

    }
}
        
        

