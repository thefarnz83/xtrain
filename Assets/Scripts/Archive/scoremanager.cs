using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoremanager : MonoBehaviour 
{
	public Text scoreTextKitchen; //Score text control on camera 1.
	private int score;
	public Text quizEndText;

	void Start ()
	{
		score = 0;
		UpdateScore ();
		//quizEndText.enabled = false;
	}

	public void AddScore (int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore ();
	}

	public void MinusScore (int newScoreValue)
	{
		score -= newScoreValue;
		UpdateScore ();
	}

	void UpdateScore ()
	{
		scoreTextKitchen.text = "Score: " + score + " /15";

		/*if (score >= 15) //Score 15 or more, you pass.
		{
			quizEndText.enabled = true;
			quizEndText.text = "Final score is: " + score + ". Congratulations! Press Escape";
			Debug.Log ("End Game Score Display");
		}*/

	}
}