using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongOfDiamondLock : MonoBehaviour {

    public bool songOfDiamondLockReady = false;
    public GameObject songOfDiamondLockButton;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void diamondSongUnlocked()
    {

        if (ResourceGeneration.diamond >= 100)
        {
            //copperLockReady.Equals(true);
            songOfDiamondLockButton.SetActive(false);
            ResourceGeneration.diamond = ResourceGeneration.diamond - 100;
        }


    }
}
