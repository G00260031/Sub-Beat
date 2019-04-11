using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoneLock : MonoBehaviour
{

    public bool stoneLockReady = false;
    public GameObject StoneLockedButton;
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

    public void purchasedStone()
    {

        if (ResourceGeneration.wood >= 5)
        {
            //stoneLockReady.Equals(true);
            StoneLockedButton.SetActive(false);
            Miner.enabled = true;
            ResourceGeneration.wood = ResourceGeneration.wood - 5;
            ResourceGeneration.stoneGeneration = 1;
        }
    }
}
