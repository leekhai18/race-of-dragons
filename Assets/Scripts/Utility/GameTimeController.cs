﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameTimeController : MonoBehaviour
{
    public Text text;    
    [HideInInspector] public bool isStart;

    private double currentTime;
    private float timer;
	
	void Start ()
    {
	
	}
		
	void Update ()
    {
	    if (isStart)
        {
            timer = (float)(PhotonNetwork.time - currentTime);
            text.text = timer.ToString("0.0");
        }
	}

    public void SetTimeStart()
    {
        isStart = true;
        currentTime = PhotonNetwork.time;
    }
}