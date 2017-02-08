using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoremanagertest : MonoBehaviour 
{
	public Text scoreText; //Score text control on camera 1.
	public int score;
	public int buttonCount;
	public gamemanagerscript managerAccess; //Allows access to the game manager script.
	public Text quizEndText;
	public Text congratulationsText;
	public Image blur;

	void Start ()
	{
		congratulationsText.enabled = false;
		blur.enabled = false;
		score = 0;
		UpdateScore ();
		congratulationsText.text = "";
		quizEndText.text = "";
	}

	public void AddScore (int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore ();
	}

	public void AddButtonCount (int newButtonCount)
	{
		buttonCount += newButtonCount;
		print ("button count is now " + newButtonCount);
		UpdateButtonCount ();
	}

	public void MinusScore (int newScoreValue)
	{
		score -= newScoreValue;
		UpdateScore ();
	}

	void UpdateScore ()
	{
		scoreText.text = "Score: " + score + " /15";
	}

	void UpdateButtonCount ()
	{
		if (buttonCount>= 15) 
		{
			blur.enabled = true;
			congratulationsText.enabled = true;
			congratulationsText.text = "Game Over!";
			managerAccess.answerresulttext.enabled = false;
			quizEndText.enabled = true;
			quizEndText.text = "Congratulations! This estimate is complete. Press Escape.";
			Debug.Log ("End Game Score Display");
		
		}
	}
}