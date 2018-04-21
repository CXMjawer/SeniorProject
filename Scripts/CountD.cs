using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountD : MonoBehaviour
{
	public int timeLeft = 1000;
	public Text countdownText;

	// Use this for initialization
	void Start()
	{
		StartCoroutine("LoseTime");
	}

	// Update is called once per frame
	void Update()
	{
		countdownText.text = ("" + timeLeft);

		if (timeLeft <= 0)
		{
			StopCoroutine("LoseTime");
			countdownText.text = "Times Up!";
			Application.LoadLevel("Login Menu");

		}
	}

	IEnumerator LoseTime()
	{
		while (true)
		{
			yield return new WaitForSeconds(1);
			timeLeft--;
		}
	}
}
