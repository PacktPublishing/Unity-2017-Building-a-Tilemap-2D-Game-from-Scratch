using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Score : MonoBehaviour {
	private Text uiText;

	private int score;

	[SerializeField]
	private int pointsToNextLevel;
	[SerializeField]
	private GameObject Winning;
	// Use this for initialization
	void Start () {
		uiText = GetComponent<Text> ();
	}
	public void IncreaseScore(int points) {
		//Increase the points
		score += points;

		//Check if the player has collected all the points to the next level
		if(score >= pointsToNextLevel) {
			//If so, show the Winning screen
			Winning.SetActive(true);

			//Disable the player controller, so the player cannot move while the Winning screen is on
			FindObjectOfType<PlayerController>().enabled = false;
		}

		//Update the Score count
		uiText.text = "Score: " + score.ToString();
	}

	// Update is called once per frame
	void Update () {
		
	}
}
