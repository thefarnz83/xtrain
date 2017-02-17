﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

public class gamemanagerscript : MonoBehaviour 
{
	public scoremanagertest scoreAccess; //This is so the question control can have access to the scoremanager.

	public GameObject tabletInterface;
	public Button roomButton;
	public GameObject startButton;
	public GameObject blurStart;
	public int scoreValue;
	public int buttonCount;
	public Text answerresulttext; //This displays after every answer input informing the user of right or wrong answer.
	public InputField userInputField; // the input field the user will type in
	public InputField userInputField2;
	[Serializable] // makes this able to be shown in the inspector if all fields are standard types
	public class QuestionAnswerSet 
	{
		// this class defines one question, and a list of answers
		public string question;
		public List<string> answers;
		public GameObject hideAnswer;
	}

	// configured in the Inspector
	public GameObject[] highlights; //Puts the highlight game objects into a list in the inspector.
	public List<QuestionAnswerSet> questionAnswerList; // list of question-to-answer sets
	private int currentQAIndex; // index of the current question-to-answer set
	private QuestionAnswerSet currentQA; // the current question-to-answer set

	private void Start() 
	{
		// initialize current question to the first in the list
		if(questionAnswerList.Count > 0) 
		{
			currentQA = questionAnswerList[0];
		}

		answerresulttext.text = "";

		startButton.SetActive (true);
		blurStart.SetActive (true);
	}

	void Update ()
	{
		userInputField.text = userInputField.text.ToUpper ();
		userInputField2.text = userInputField2.text.ToUpper ();

		if (Input.GetKey ("escape"))
			Application.Quit ();
	}
		
	public void NextQuestion() 
	{
		currentQAIndex++;
		// if there is no next question, go back to the first question (customize to the behaviour you'd like)
		if(questionAnswerList.Count <= currentQAIndex) 
		{
			currentQAIndex = 0;
		}
		currentQA = questionAnswerList[currentQAIndex];

		// display question somehow
		string question = currentQA.question;
	}

	public void Submit() 
	{
		string[] userAnswers = (userInputField.text + " " + userInputField2.text).Split(',');

		// if any of their answers matches one in the question/answer set, it's correct
		foreach(string userAnswer in userAnswers) 
		{
			if (currentQA.answers.Contains (userAnswer)) 
			{
				answerresulttext.text = "'" + userAnswer + "' is correct!"; //Displays results on screen for user.
				userInputField.text = ""; //Sets userinput to empty.
				userInputField2.text = ""; //Sets userinput to empty.
				tabletInterface.SetActive (false);
				scoreAccess.AddScore (scoreValue);
				scoreAccess.AddButtonCount (buttonCount);
				roomButton.interactable = true;
				currentQA.hideAnswer.SetActive (false);
				for (int i = 0; i < highlights.Length; i++) //For loop checks the highlight list and sets any active to inactive.
					highlights [i].SetActive (false);
				break;
			}

			else 
			{
				Debug.Log (userAnswer);
				answerresulttext.text = "'" + userAnswer + "' is incorrect! The correct answer is: '" + currentQA.answers [0] + "'";
				//tabletInterface.SetActive (false);
				//scoreAccess.AddButtonCount (buttonCount);
				print ("User answer: '" + userAnswer + "' is incorrect! The correct answer is: '" + currentQA.answers[0] + /*"," + currentQA.answers[1] + */"'");
			}
		}
	}

	public void SetQuestion(int index)
	{
		currentQAIndex = index;
		currentQA = questionAnswerList[currentQAIndex];
	}

	public void ActivateSystem ()
	{
		tabletInterface.SetActive (true);
	}

	public void GoGoBananas ()
	{
		startButton.SetActive (false);
		blurStart.SetActive (false);
	}
}