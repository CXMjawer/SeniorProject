using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cleaned : MonoBehaviour {


	AudioSource Source;
	public float DestroyTimer = 5.0f;
	public Slider slider;
	void Start()  	{ 
		Source = GetComponent<AudioSource>(); 
	}


	void OnTriggerEnter(Collider Other)
	{slider = GameObject.Find("NORMAL MODE/3RD Person/Canvas/MapIcon/Slider").GetComponent<Slider>();
		Destroy (gameObject, DestroyTimer);//This is to free up ram...
		if (Other.gameObject.CompareTag("Player")){
			//INFOS

			Cleaning.Clearing+=1;
			slider.value+=0.2f;
			PercentCollected.PercentNum += 0.67f;
			if (Cleaning.Clearing == 15) {
				TrophiesCollected.TrophiesAmount+=1;
				PercentCollected.PercentNum += 0.67f;
			}
			ScoreCollected.ScoreAmount+=300;//300 Score!
			Source.clip = Resources.Load<AudioClip>("Shined");
			Source.Play();

			gameObject.GetComponent<Renderer>().enabled = false;
			gameObject.GetComponent<Collider>().enabled = false;


		}

	}
}