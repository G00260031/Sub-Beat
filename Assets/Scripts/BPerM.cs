using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPerM : MonoBehaviour { 
    private static BPerM BPerMInstance;
    public float bpm;
    private float beatInterval;
    private float beatTimer;
    private float beatIntervalHalf;
    private float beatTimerHalf;
    private float beatIntervalD4;
    private float beatTimerD4;
    private float beatIntervalD8;
    private float beatTimerD8;
    private float beatIntervalD16;
    private float beatTimerD16;
    private double beatIntervalUp;
    private float beatTimerUp;
    public static bool beatFull;
    public static bool beatHalf;
    public static bool beatD4;
    public static bool beatD8;
    public static bool beatD16;
    public static bool beatUp;
    public static int beatCountFull;
    public static int beatCountHalf;
    public static int beatCountD4;
    public static int beatCountD8;
    public static int beatCountD16;
    public static int beatCountUp;


    private void Awake()
    {
        if (BPerMInstance != null && BPerMInstance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            BPerMInstance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        BeatDetection();
		
	}

    void BeatDetection()
    {
        //Full Beat
        beatFull = false;
        beatInterval = 60 / bpm;
        beatTimer += Time.deltaTime;
        if(beatTimer >= beatInterval)
        {
            beatTimer -= beatInterval;
            beatFull = true;
            beatCountFull++;
            //Debug.Log("Whole Beat");
        }

        beatUp = false;
        beatIntervalUp = .5 + (60 / bpm);
        beatTimer += Time.deltaTime;
        if(beatTimer >= beatInterval)
        {
            beatTimer -= beatInterval;
            beatUp = true;
            beatCountUp++;
            Debug.Log("Up Beat");
        }



        /*Beat Half Notes
        beatHalf = false;
        beatIntervalHalf = beatInterval / 2;
        beatTimerHalf += Time.deltaTime;
        if (beatTimerHalf >= beatIntervalHalf)
        {
            beatTimerHalf -= beatIntervalHalf;
            beatHalf = true;
            beatCountHalf++;
            Debug.Log("Half Note");
        }

        //Beat Divided by 4
        beatD4 = false;
        beatIntervalD4 = beatInterval / 4;
        beatTimerD4 += Time.deltaTime;
        if (beatTimerD4 >= beatIntervalD4)
        {
            beatTimerD4 -= beatIntervalD4;
            beatD4 = true;
            beatCountD4++;
            Debug.Log("Quarter Note");
        }
        */

        //Beat Divided by 8
        beatD8 = false;
        beatIntervalD8 = beatInterval / 8;
        beatTimerD8 += Time.deltaTime;
        if(beatTimerD8 >= beatIntervalD8)
        {
            beatTimerD8 -= beatIntervalD8;
            beatD8 = true;
            beatCountD8++;
            //Debug.Log("Eighth Note");
        }

        /*

        //Beat Divided by 16
        beatD16 = false;
        beatIntervalD16 = beatInterval / 16;
        beatTimerD16 += Time.deltaTime;
        if (beatTimerD16 >= beatIntervalD16)
        {
            beatTimerD16 -= beatIntervalD16;
            beatD16 = true;
            beatCountD16++;
            Debug.Log("Sixteenth Note");
        }
        */

    }
}
