using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IronLock : MonoBehaviour
{

    public bool ironLockReady = false;
    public GameObject IronLockedButton;
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

    public void purchasedIron()
    {

        if (ResourceGeneration.wood >= 5)
        {
            //copperLockReady.Equals(true);
            IronLockedButton.SetActive(false);
            Miner.enabled = true;
            ResourceGeneration.wood = ResourceGeneration.wood - 5;
            ResourceGeneration.ironGeneration = 1;
        }


    }
}
