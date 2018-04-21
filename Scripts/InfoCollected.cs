using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoCollected : MonoBehaviour {
	
	public static int CoinsAmount=0;
	Text text;
	
	void Start () {
		text = GetComponent<Text>();
	}
	

	void Update () {
		text.text = CoinsAmount.ToString();
	}
}
