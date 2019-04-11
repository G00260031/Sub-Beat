using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongOfGoldLock : MonoBehaviour {

    public bool songOfGoldLockReady = false;
    public GameObject songOfGoldLockButton;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void goldSongUnlocked()
    {

        if (ResourceGeneration.diamond >= 15)
        {
            //copperLockReady.Equals(true);
            songOfGoldLockButton.SetActive(false);
            ResourceGeneration.diamond = ResourceGeneration.diamond - 15;
        }


    }
}
