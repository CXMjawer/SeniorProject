using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCollected : MonoBehaviour {
	
	public static int ScoreAmount;
	Text text;
	
	void Start () {
		text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = ScoreAmount.ToString();
	}
}
