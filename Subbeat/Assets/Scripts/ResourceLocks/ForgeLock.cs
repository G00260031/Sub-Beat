using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForgeLock : MonoBehaviour {

    public bool forgeLockReady = false;
    public GameObject ForgeLockedButton;
    public GameObject BlinkingUpgrade;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ResourceGeneration.wood >= 5)
        {
            BlinkingUpgrade.GetComponent<Image>().enabled = true;
        }
    }

    public void purchasedForge()
    {

        if (ResourceGeneration.wood >= 5)
        {
            //copperLockReady.Equals(true);
            ForgeLockedButton.SetActive(false);
            ResourceGeneration.wood = ResourceGeneration.wood - 5;
            ResourceGeneration.steelGeneration = 1;
        }


    }
}