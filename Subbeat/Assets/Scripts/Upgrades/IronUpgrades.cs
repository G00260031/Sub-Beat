using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronUpgrades : MonoBehaviour {

    public static bool ironUpgrade1 = false;
    public static bool ironUpgrade1Obtained = true;
    public static bool ironUpgrade2 = false;
    public static bool ironUpgrade2Obtained = false;
    public static bool ironUpgrade3 = false;
    public static bool ironUpgrade4 = false;
    public static bool ironUpgrade5 = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (ResourceGeneration.wood >= 15 && ironUpgrade1Obtained.Equals(true))
        {
            ironUpgrade2 = true;
            //Debug.Log("Stone upgrade2 is available");
        }
        else if (ResourceGeneration.wood >= 10)
        {
            ironUpgrade1 = true;
            //Debug.Log("Stone upgrade is available");
        }

    }
}