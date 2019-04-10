using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondUpgrades : MonoBehaviour {

    public static bool diamondUpgrade1 = false;
    public static bool diamondUpgrade1Obtained = true;
    public static bool diamondUpgrade2 = false;
    public static bool diamondUpgrade2Obtained = false;
    public static bool diamondUpgrade3 = false;
    public static bool diamondUpgrade4 = false;
    public static bool diamondUpgrade5 = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (ResourceGeneration.wood >= 15 && diamondUpgrade1Obtained.Equals(true))
        {
            diamondUpgrade2 = true;
            //Debug.Log("Stone upgrade2 is available");
        }
        else if (ResourceGeneration.wood >= 10)
        {
            diamondUpgrade1 = true;
            //Debug.Log("Stone upgrade is available");
        }

    }
}
