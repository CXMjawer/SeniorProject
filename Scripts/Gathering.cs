using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gathering : MonoBehaviour {

		private static int CollectFiveInfosToGetOneStar = 0;
		private static int CollectFiveStarsToGetOneTrophy = 0;
		public GameObject ObjectAnimatorON; 
	    public GameObject ObjectON; 
	 	AudioSource Source;
	 	public Slider slider;


	void Start()
	{
		Source = GetComponent<AudioSource>();
	}


	void OnTriggerEnter(Collider Other){
slider = GameObject.Find("NORMAL MODE/3RD Person/Canvas/MapIcon/Slider").GetComponent<Slider>();
		
			Destroy (gameObject, 5f);
			if (Other.gameObject.CompareTag("Player")){
			InfoCollected.CoinsAmount += 1;
			slider.value+=0.1f;
			PercentCollected.PercentNum += 0.67f;
			ScoreCollected.ScoreAmount+=100;
			Source.clip = Resources.Load<AudioClip>("coin");
			Source.Play();
			CollectFiveInfosToGetOneStar += 1;
			ObjectON.SetActive (true);

			if (CollectFiveInfosToGetOneStar == 5){
		    CollectFiveInfosToGetOneStar=0;
			StarsCollected.StarsAmount+=1;
			slider.value+=0.2f;
			PercentCollected.PercentNum += 0.67f;
			ScoreCollected.ScoreAmount+=500;
			Source.clip = Resources.Load<AudioClip>("Star");
			Source.Play();
			CollectFiveStarsToGetOneTrophy+=1;
						
		}

			if (CollectFiveStarsToGetOneTrophy == 5){
			TrophiesCollected.TrophiesAmount+=1;
			PercentCollected.PercentNum += 0.67f;
			slider.value+=0.3f;
			ScoreCollected.ScoreAmount+=5000;
			Source.clip = Resources.Load<AudioClip> ("Victory");
			Source.Play ();

		}

		gameObject.GetComponent<Renderer>().enabled = false;
   		gameObject.GetComponent<Collider>().enabled = false;
		}
}


	void Update(){
		if (CollectFiveStarsToGetOneTrophy == 5) {
			ObjectAnimatorON.SetActive(true);
			CollectFiveStarsToGetOneTrophy = 0;
		}
		if (CollectFiveStarsToGetOneTrophy == 3){
			ObjectAnimatorON.SetActive(false);
		}
		if (InfoCollected.CoinsAmount >= 100){
			InfoCollected.CoinsAmount =100;
		}
		if(StarsCollected.StarsAmount >= 25){
			StarsCollected.StarsAmount = 25;
		}
		if(TrophiesCollected.TrophiesAmount >= 5){
			TrophiesCollected.TrophiesAmount = 5;
			CollectFiveInfosToGetOneStar = 0;
		    CollectFiveStarsToGetOneTrophy = 0;
			Destroy (ObjectAnimatorON.gameObject, 1);
		}
		if(PercentCollected.PercentNum >= 100){
			PercentCollected.PercentNum = 100;
		}
			if(QuizCollected.QuizAmount >= 10){
				QuizCollected.QuizAmount  = 10;
		}
	}
}