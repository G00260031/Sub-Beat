using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldLock : MonoBehaviour {

    public bool goldLockReady = false;
    public GameObject GoldLockedButton;
    public GameObject BlinkingUpgrade;
    public Animator Miner;

    // Use this for initialization
    void Start()
    {
        Miner.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ResourceGeneration.wood >= 5)
        {
            BlinkingUpgrade.GetComponent<Image>().enabled = true;
        }
    }

    public void purchasedGold()
    {

        if (ResourceGeneration.wood >= 5)
        {
            //copperLockReady.Equals(true);
            GoldLockedButton.SetActive(false);
            Miner.enabled = true;
            ResourceGeneration.wood = ResourceGeneration.wood - 5;
            ResourceGeneration.goldGeneration = 1;
        }


    }
}