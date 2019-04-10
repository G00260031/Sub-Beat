using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WoodUpgrades : MonoBehaviour {

    public static bool woodStart = true;
    public static bool woodUpgrade1 = false;
    public static bool woodUpgrade1Obtained = false;
    public static bool woodUpgrade2 = false;
    public static bool woodUpgrade2Obtained = false;
    public static bool woodUpgrade3 = false;
    public static bool woodUpgrade3Obtained = false;
    public static bool woodUpgrade4 = false;
    public static bool woodUpgrade4Obtained = false;
    public static bool woodUpgrade5 = false;
    public static bool woodUpgrade5Obtained = false;
    public static bool woodUpgradeMaxed = false;
    public GameObject woodUpgradeSelect;
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void woodUpgrade()
    {
        if(woodUpgrade5.Equals(true))
        {
            if(ResourceGeneration.wood >= 5)
            {
                ResourceGeneration.wood = ResourceGeneration.wood - 5;
                ResourceGeneration.woodGeneration = 6;
                woodUpgradeSelect.SetActive(false);
            }
        }

        else if (woodUpgrade4.Equals(true))
        {
            if (ResourceGeneration.wood >= 5)
            {
                ResourceGeneration.wood = ResourceGeneration.wood - 5;
                ResourceGeneration.woodGeneration = 5;
                woodUpgrade5 = true;
                woodUpgrade4 = false;
            }
        }
        else if (woodUpgrade3.Equals(true))
        {
            if (ResourceGeneration.wood >= 5)
            {
                ResourceGeneration.wood = ResourceGeneration.wood - 5;
                ResourceGeneration.woodGeneration = 4;
                woodUpgrade4 = true;
                woodUpgrade3 = false;
            }
        }
        else if (woodUpgrade2.Equals(true))
        {
            if (ResourceGeneration.wood >= 5)
            {
                ResourceGeneration.wood = ResourceGeneration.wood - 5;
                ResourceGeneration.woodGeneration = 3;
                woodUpgrade3 = (true);
                woodUpgrade2 = (false);
                Debug.Log("WoodUpgrade3 is true");
            }
        }
        else if (ResourceGeneration.wood >= 5 && woodStart.Equals(true))
        {
            ResourceGeneration.wood = ResourceGeneration.wood - 5;
            ResourceGeneration.woodGeneration = 2;
            woodUpgrade2 = true;
            woodStart = false;
            Debug.Log("WoodUpgrade2 is true");
        }
        
    }
}
