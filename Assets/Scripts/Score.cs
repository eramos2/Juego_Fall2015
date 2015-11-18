using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Text score;

	private int totalScore;

	// Use this for initialization
	void Start () {
	
		if (!score)
			score = GetComponent<Text> ();

		if (PlayerPrefs.HasKey("TotalScore")) 
			totalScore = PlayerPrefs.GetInt("TotalScore");

		if (score)
			score.text = "Total Score: " + totalScore.ToString ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
