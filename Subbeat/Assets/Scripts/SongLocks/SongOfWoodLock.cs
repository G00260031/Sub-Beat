using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongOfWoodLock : MonoBehaviour {

    public bool songOfWoodLockReady = false;
    public GameObject songOfWoodLockButton;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void woodSongUnlocked()
    {

        if (ResourceGeneration.stone >= 15)
        {
            //copperLockReady.Equals(true);
            songOfWoodLockButton.SetActive(false);
            ResourceGeneration.stone = ResourceGeneration.stone - 15;
        }


    }
}
