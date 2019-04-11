using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForgeUpgrades : MonoBehaviour {

    public static bool forgeUpgrade1 = false;
    public static bool forgeUpgrade1Obtained = true;
    public static bool forgeUpgrade2 = false;
    public static bool forgeUpgrade2Obtained = false;
    public static bool forgeUpgrade3 = false;
    public static bool forgeUpgrade4 = false;
    public static bool forgeUpgrade5 = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (ResourceGeneration.wood >= 15 && forgeUpgrade1Obtained.Equals(true))
        {
            forgeUpgrade2 = true;
            //Debug.Log("Stone upgrade2 is available");
        }
        else if (ResourceGeneration.wood >= 10)
        {
            forgeUpgrade1 = true;
            //Debug.Log("Stone upgrade is available");
        }

    }
}
