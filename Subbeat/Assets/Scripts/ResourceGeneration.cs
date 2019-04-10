using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ResourceGeneration : MonoBehaviour {

    public static float wood;
    public static float stone;
    public static float copper;
    public static float iron;
    public static float steel;
    public static float gold;
    public static float diamond;
    public static float woodGeneration = 1;
    public static float stoneGeneration = 0;
    public static float copperGeneration = 0;
    public static float ironGeneration = 0;
    public static float steelGeneration = 0;
    public static float goldGeneration = 0;
    public static float diamondGeneration = 0;

    public Text woodCountText;
    public Text stoneCountText;
    public Text copperCountText;
    public Text ironCountText;
    public Text steelCountText;
    public Text goldCountText;
    public Text diamondCountText;
    public Button woodSong;
    public Button stoneSong;
    public Button copperSong;
    public Button ironSong;
    public Button forgeSong;
    public Button goldSong;
    public Button diamondSong;
    public bool woodButton;
    public bool stoneButton;
    public bool ironButton;



	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        woodCountText.text = wood.ToString();
        stoneCountText.text = stone.ToString();
        copperCountText.text = copper.ToString();
        ironCountText.text = iron.ToString();
        steelCountText.text = steel.ToString();
        goldCountText.text = gold.ToString();
        diamondCountText.text = diamond.ToString();


        /*
        if (
        {
            woodButton.Equals(true);
            Debug.Log("Wood song is a goin'");
        }
        */


    }

}

