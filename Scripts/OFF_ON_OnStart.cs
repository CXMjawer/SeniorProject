﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OFF_ON_OnStart : MonoBehaviour {

	public GameObject EnableObject;
    public GameObject DisableObject;

	void Start () {
		
	EnableObject.SetActive(true);
	DisableObject.SetActive(false);
	}
	
}
