﻿/*
 * Author: Brett Moody @bam4
 * Editor: Marcus Guimaraes @mzguimaraes
 */


using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AlarmTimerBrett : MonoBehaviour {


	public Text timeRemainingText;
	public static float timeLeft = 999;

	//public AudioSource AlarmSFX;
	//public AudioClip Alarm;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

//		if (timeLeft <= 30) {
//			AlarmSFX.PlayOneShot (Alarm);
//		}

		if (timeLeft > 0) {
			timeLeft -= Time.deltaTime;
			timeRemainingText.text = (int)timeLeft + " seconds left.";
		}

		if (timeLeft <= 0) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

		}

	}
}
