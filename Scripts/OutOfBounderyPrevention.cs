using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounderyPrevention : MonoBehaviour {

	[SerializeField] private Transform player1;
	[SerializeField] private Transform player2;
	[SerializeField] private Transform RespawnPoint;
	[SerializeField] private AudioSource SoundEffect;
	
    void Start(){
	SoundEffect = GetComponent<AudioSource>();
    }


    void OnTriggerEnter(Collider Col){
	player1.transform.position = RespawnPoint.transform.position;
	player2.transform.position = RespawnPoint.transform.position;
	SoundEffect.clip = Resources.Load<AudioClip>("Warp");
	SoundEffect.Play();
	}
}

