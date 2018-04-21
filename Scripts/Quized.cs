using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quized : MonoBehaviour {

	    public GameObject ObjectON; 
	 	AudioSource Source;


	void Start()
	{
		Source = GetComponent<AudioSource>();
	}


	void OnTriggerEnter(Collider Other){
		
			
			if (Other.gameObject.CompareTag("Player")){
			QuizCollected.QuizAmount += 1;
			PercentCollected.PercentNum += 0.6f;
			ObjectON.SetActive (true);
			//ScoreCollected.ScoreAmount += 600;
			//Source.clip = Resources.Load<AudioClip>("True");
			//Source.Play();
			


		gameObject.GetComponent<Renderer>().enabled = false;
   		gameObject.GetComponent<Collider>().enabled = false;
   		//Destroy (gameObject, 5f);
		}
}
}

				