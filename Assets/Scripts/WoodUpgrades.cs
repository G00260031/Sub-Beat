using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodUpgrades : MonoBehaviour {

    public static bool woodUpgrade1 = false;
    public static bool woodUpgrade1Obtained = false;
    public static bool woodUpgrade2 = false;
    public static bool woodUpgrade2Obtained = false;
    public static bool woodUpgrade3 = false;
    public static bool woodUpgrade4 = false;
    public static bool woodUpgrade5 = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (ResourceGeneration.wood >= 15 && woodUpgrade1.Equals(true))
        {
            woodUpgrade2 = true;
            //Debug.Log("Wood upgrade2 is available");
        }
        else if (ResourceGeneration.wood >= 10)
        {
            woodUpgrade1 = true;
            //Debug.Log("Wood upgrade is available");
        }


    }
}
