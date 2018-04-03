using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class DayNight : MonoBehaviour {


	public float time;
	public TimeSpan currantTime;
	public Transform sunTransf;
	public Light sun;
	public Text timeText;


	public float intensity;
	public Color foggyday = Color.grey;
	public Color foggyNight = Color.black;

	public int speed;
	// Update is called once per frame
	void Update () {
		ChangeTime ();

	}

	public void ChangeTime(){
		time += Time.deltaTime * speed;
		if (time > 86400) {
			time = 0;
		}

		currantTime = TimeSpan.FromSeconds (time);
		string[] timet = currantTime.ToString ().Split (":" [0]);
		timeText.text = timet [0] + ":" + timet [1];

		sunTransf.rotation = Quaternion.Euler (new Vector3 ((time - 21600) / 86400 * 360, 0));

		if (time > 79000 || time < 10000) {
			sun.intensity = 0.2f;
		} else if (time > 67000) {
			sun.intensity = 1.3f;
		} else {
			sun.intensity = 1;
		}

			

	/*	if (time > 43200) {
			intensity = 1 - (43200 - time) / 43200;
		} else {
			intensity = 1 - ((43200 - time) / 43200 * -1);
		}

		RenderSettings.fogColor = Color.Lerp (foggyday, foggyNight, intensity * intensity);

		sun.intensity = intensity;*/
	}


}
