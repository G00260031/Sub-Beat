using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {
    public int bankSize;
    private List<AudioSource> soundClip;

	// Use this for initialization
	void Start () {

        soundClip = new List<AudioSource>();
        for(int i = 0; i < bankSize; i++)
        {
            GameObject soundInstance = new GameObject("sound");
            soundInstance.AddComponent<AudioSource>();
            soundInstance.transform.parent = this.transform;
            soundClip.Add(soundInstance.GetComponent<AudioSource>());
        }
		
	}


    public void PlaySound(AudioClip clip, float volume)
    {
        for (int i = 0; i < soundClip.Count; i++)
        {
            if(!soundClip[i].isPlaying)
            {
                soundClip[i].clip = clip;
                soundClip[i].volume = volume;
                soundClip[i].Play();
                return;
            }
        }
        GameObject soundInstance = new GameObject("sound");
        soundInstance.AddComponent<AudioSource>();
        soundInstance.transform.parent = this.transform;
        soundInstance.GetComponent<AudioSource>().clip = clip;
        soundInstance.GetComponent<AudioSource>().volume = volume;
        soundInstance.GetComponent<AudioSource>().Play();
        soundClip.Add(soundInstance.GetComponent<AudioSource>());
    }
	

		
}

