using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldUpgrades : MonoBehaviour {

    public static bool goldUpgrade1 = false;
    public static bool goldUpgrade1Obtained = true;
    public static bool goldUpgrade2 = false;
    public static bool goldUpgrade2Obtained = false;
    public static bool goldUpgrade3 = false;
    public static bool goldUpgrade4 = false;
    public static bool goldUpgrade5 = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (ResourceGeneration.wood >= 15 && goldUpgrade1Obtained.Equals(true))
        {
            goldUpgrade2 = true;
            //Debug.Log("Stone upgrade2 is available");
        }
        else if (ResourceGeneration.wood >= 10)
        {
            goldUpgrade1 = true;
            //Debug.Log("Stone upgrade is available");
        }

    }
}
