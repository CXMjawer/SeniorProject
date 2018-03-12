using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gathering : MonoBehaviour {

		private static int CollectFiveInfosToGetOneStar = 0;
		private static int CollectFiveStarsToGetOneTrophy = 0;
	 	public AudioSource Source;

	void Start()
	{
		 Source = GetComponent<AudioSource>();
	
	}


	void OnTriggerEnter(Collider Other)
	{
	   if (Other.gameObject.CompareTag("Player"))
	  
	   	{
//INFOS
		InfoCollected.CoinsAmount += 1;

		CollectFiveInfosToGetOneStar += 1;
//STARS
		if (CollectFiveInfosToGetOneStar == 5){
			
			StarsCollected.StarsAmount+=1;
			CollectFiveStarsToGetOneTrophy+=1;
			CollectFiveInfosToGetOneStar=0;
		}
//TROPHIES
		if (CollectFiveStarsToGetOneTrophy == 5){
			CollectFiveStarsToGetOneTrophy=0;
			TrophiesCollected.TrophiesAmount+=1;
		}
		Source.Play();

   		gameObject.GetComponent<Renderer>().enabled = false;
   		gameObject.GetComponent<Collider>().enabled = false;
				//gameObject.SetActive(false);
				//Destroy (gameObject);
   			    //Source.pitch++;
				//Source.pitch++;
				//if (Source.pitch >=  5 ){
				//Source.pitch=-1;
				//}
		
		}

	}
}