using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongOfCopperLock : MonoBehaviour {

    public bool songOfCopperLockReady = false;
    public GameObject songOfCopperLockButton;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void copperSongUnlocked()
    {

        if (ResourceGeneration.iron >= 15)
        {
            //copperLockReady.Equals(true);
            songOfCopperLockButton.SetActive(false);
            ResourceGeneration.iron = ResourceGeneration.iron - 15;
        }


    }
}
