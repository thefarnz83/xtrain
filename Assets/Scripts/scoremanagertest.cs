using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoremanagertest : MonoBehaviour 
{
	public Text scoreText; //Score text control on camera 1.
	public int score;
	//public Text quizEndText;

	//---------------- Game Over Idea ---------------------------




	public Text congratulationsText;
	public Image blur;

	void Start ()
	{
		congratulationsText.enabled = false;
		blur.enabled = false;
		score = 0;
		UpdateScore ();
		congratulationsText.text = "";
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
		scoreText.text = "Score: " + score + " /15";

		/*if (score >= 15) //Score 15 or more, you pass.
		{
			quizEndText.enabled = true;
			quizEndText.text = "Final score is: " + score + ". Congratulations! Press Escape";
			Debug.Log ("End Game Score Display");
		}*/

		if (score >= 15) 
		{
			//Debug.Log ("score is less then 1");
			blur.enabled = true;
			congratulationsText.enabled = true;
			congratulationsText.text = "Game Over!";
	
		}
	}

	//---------------- Game Over Idea ---------------------------
	/*public void TheEnd ()
	{
		
	}*/
}