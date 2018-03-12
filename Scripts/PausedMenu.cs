using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using System;

public class PausedMenu : MonoBehaviour {
		public Transform Pause;
		public Transform Player;

		void Update()
		{
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				if (Pause.gameObject.activeInHierarchy == false){
					Pause.gameObject.SetActive(true);
					Time.timeScale=0;
					AudioListener.volume = 0;
					Player.GetComponent<FirstPersonController>().enabled = false;
				}else{

					Pause.gameObject.SetActive(false);
					Time.timeScale=1;
					AudioListener.volume = 1;
					Player.GetComponent<FirstPersonController>().enabled = true;
				
				}
			}
		}
	public void SetLevel(){
		Application.LoadLevel ("StartMenu");
	}
	public void SetResume(){
		
					Pause.gameObject.SetActive(false);
					Time.timeScale=1;
					AudioListener.volume = 1;
					Player.GetComponent<SimpleCharacterControl>().enabled = true;
					Player.GetComponent<ThirdPersonCharacter>().enabled = true;
					Player.GetComponent<ThirdPersonUserControl>().enabled = true;
				

	}


}
