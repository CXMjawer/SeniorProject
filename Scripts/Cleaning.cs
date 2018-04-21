using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cleaning : MonoBehaviour {
	
	public static int Clearing;
	public AudioSource Source;
	public GameObject ObjectAnimatorON; 
	public float DestroyTimer = 5.0f;
	public short ModifyValue = 0;
	short x=0;
	Text text;
	
	void Start () {
		text = GetComponent<Text>();
		Source = GetComponent<AudioSource>();
	
	}
	
	// Update is called once per frame
	void Update () {
		//Cleaning.Cleans=ModifyValue;
		text.text = Clearing.ToString();
		if(Cleaning.Clearing == 15){
			Cleaning.Clearing=15;
			
				if (x == 0) {
					Source.clip = Resources.Load<AudioClip> ("Victory");
					Source.Play ();
					ObjectAnimatorON.GetComponent<Animator>().enabled = true;
					Destroy (ObjectAnimatorON.gameObject, DestroyTimer);
					x = 1;
				
			}
		}
	}
}