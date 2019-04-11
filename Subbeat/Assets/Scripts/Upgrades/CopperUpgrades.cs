using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopperUpgrades : MonoBehaviour {

    public static bool copperStart = true;
    public static bool copperUpgrade1 = false;
    public static bool copperUpgrade1Obtained = true;
    public static bool copperUpgrade2 = false;
    public static bool copperUpgrade2Obtained = false;
    public static bool copperUpgrade3 = false;
    public static bool copperUpgrade4 = false;
    public static bool copperUpgrade5 = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
              
    }

    public void copperUpgrade()
    {
        if(ResourceGeneration.copper >= 5 && copperStart.Equals(true))
        {
            ResourceGeneration.copper = ResourceGeneration.copper - 5;
            ResourceGeneration.copperGeneration = ResourceGeneration.copperGeneration + 1;
            copperUpgrade2.Equals(true);
            copperStart.Equals(false);
        }
        else if (copperUpgrade2.Equals(true))
        {
            if (ResourceGeneration.copper >= 5)
            {
                ResourceGeneration.copper = ResourceGeneration.copper - 5;
                ResourceGeneration.copperGeneration = ResourceGeneration.copperGeneration + 1;
                copperUpgrade3.Equals(true);
                copperUpgrade2.Equals(false);

            }
        }
        else if (copperUpgrade3.Equals(true))
        {
            if (ResourceGeneration.copper >= 5)
            {
                ResourceGeneration.copper = ResourceGeneration.copper - 5;
                ResourceGeneration.copperGeneration = ResourceGeneration.copperGeneration + 1;
                copperUpgrade4.Equals(true);
                copperUpgrade3.Equals(false);
            }
        }
        else if (copperUpgrade4.Equals(true))
        {
            if (ResourceGeneration.copper >= 5)
            {
                ResourceGeneration.copper = ResourceGeneration.copper - 5;
                ResourceGeneration.copperGeneration = ResourceGeneration.copperGeneration + 1;
                copperUpgrade5.Equals(true);
                copperUpgrade4.Equals(false);
            }
        }
        else if (ResourceGeneration.copper >= 5 && copperUpgrade5.Equals(true))
        {
            ResourceGeneration.copper = ResourceGeneration.copper - 5;
            ResourceGeneration.copperGeneration = ResourceGeneration.copperGeneration + 1;
            copperUpgrade5.Equals(false);
            
        }

    }
}