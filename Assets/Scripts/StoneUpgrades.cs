using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneUpgrades : MonoBehaviour {

    public static bool stoneUpgrade1 = false;
    public static bool stoneUpgrade1Obtained = true;
    public static bool stoneUpgrade2 = false;
    public static bool stoneUpgrade2Obtained = false;
    public static bool stoneUpgrade3 = false;
    public static bool stoneUpgrade4 = false;
    public static bool stoneUpgrade5 = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if (ResourceGeneration.wood >= 15 && stoneUpgrade1Obtained.Equals(true))
        {
             stoneUpgrade2 = true;
             //Debug.Log("Stone upgrade2 is available");
        }
        else if (ResourceGeneration.wood >= 10)
        {
            stoneUpgrade1 = true;
            //Debug.Log("Stone upgrade is available");
        }            
    }
}
