using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SongOfIronLock : MonoBehaviour {

    public bool songOfIronLockReady = false;
    public GameObject songOfIronLockButton;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ironSongUnlocked()
    {

        if (ResourceGeneration.steel >= 15)
        {
            //copperLockReady.Equals(true);
            songOfIronLockButton.SetActive(false);
            ResourceGeneration.steel = ResourceGeneration.steel - 15;
        }


    }
}
