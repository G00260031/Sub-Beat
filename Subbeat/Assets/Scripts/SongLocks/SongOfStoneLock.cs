using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongOfStoneLock : MonoBehaviour {

    public bool songOfStoneLockReady = false;
    public GameObject songOfStoneLockButton;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void stoneSongUnlocked()
    {

        if (ResourceGeneration.copper >= 15)
        {
            //copperLockReady.Equals(true);
            songOfStoneLockButton.SetActive(false);
            ResourceGeneration.copper = ResourceGeneration.copper - 15;
        }


    }
}
