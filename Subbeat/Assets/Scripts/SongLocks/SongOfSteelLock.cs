using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongOfSteelLock : MonoBehaviour {

    public bool songOfSteelLockReady = false;
    public GameObject songOfSteelLockButton;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void steelSongUnlocked()
    {

        if (ResourceGeneration.gold >= 15)
        {
            //copperLockReady.Equals(true);
            songOfSteelLockButton.SetActive(false);
            ResourceGeneration.gold = ResourceGeneration.gold - 15;
        }


    }
}
