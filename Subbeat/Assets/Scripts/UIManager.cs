using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{

    public RectTransform subBeat, settingsMenu, upgradeMenu, musicMenu;



	// Use this for initialization
	void Start ()
    {
        subBeat.DOAnchorPos(Vector2.zero, 0.25f);
	}
	
    public void SettingsButton()
    {
        subBeat.DOAnchorPos(new Vector2(350, 0), 0.25f);
        settingsMenu.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void CloseSettingsButton()
    {
        subBeat.DOAnchorPos(new Vector2(0, 0), 0.25f);
        settingsMenu.DOAnchorPos(new Vector2(-350, 0), 0.25f);
    }

    public void UpgradeButton()
    {
        subBeat.DOAnchorPos(new Vector2(0, -600), 0.25f);
        upgradeMenu.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void CloseUpgradeButton()
    {
        subBeat.DOAnchorPos(new Vector2(0, 0), 0.25f);
        upgradeMenu.DOAnchorPos(new Vector2(0, 600), 0.25f);
    }

    public void MusicButton()
    {
        subBeat.DOAnchorPos(new Vector2(-350, 0), 0.25f);
        musicMenu.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void CloseMusicButton()
    {
        subBeat.DOAnchorPos(new Vector2(0, 0), 0.25f);
        musicMenu.DOAnchorPos(new Vector2(350, 0), 0.25f);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
