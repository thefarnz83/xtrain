using UnityEngine;
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
	public GameObject green, red;
	public int scoreValue;
	public int buttonCount;
	public Text correctAnswerresulttext; //This displays after every answer input informing the user of right or wrong answer.
	public Text wrongAnswerresulttext;
	public Text currentQuestion;
	public InputField userInputField; //The input field the user will type in
	public InputField userInputField2;
	[Serializable] //Makes this able to be shown in the inspector if all fields are standard types
	public class QuestionAnswerSet 
	{
		//This class defines one question, and a list of answers
		public string question;
		public List<string> answers;
		public GameObject hideAnswer;
	}

	//Configured in the Inspector
	public GameObject[] highlights; //Puts the highlight game objects into a list in the inspector.
	public List<QuestionAnswerSet> questionAnswerList; //List of question-to-answer sets
	private int currentQAIndex; //Index of the current question-to-answer set
	[HideInInspector] //Hides var below.
	public QuestionAnswerSet currentQA; //The current question-to-answer set.

	private void Start() 
	{
		//Initialize current question to the first in the list
		if(questionAnswerList.Count > 0) 
		{
			currentQA = questionAnswerList[0];
		}

		correctAnswerresulttext.text = "";
		wrongAnswerresulttext.text = "";
		currentQuestion.text = "";
		startButton.SetActive (true);
		blurStart.SetActive (true);
		green.SetActive (false);
		red.SetActive (false);
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
		//If there is no next question, go back to the first question (customize to the behaviour you'd like)
		if(questionAnswerList.Count <= currentQAIndex) 
		{
			currentQAIndex = 0;
		}
		currentQA = questionAnswerList[currentQAIndex];

		//Display question somehow
		string question = currentQA.question;
	}

	public void Submit() 
	{
		string[] userAnswers = (userInputField.text + " " + userInputField2.text).Split(',');

		//If any of their answers matches one in the question/answer set, it's correct
		foreach(string userAnswer in userAnswers) 
		{
			if (currentQA.answers.Contains (userAnswer)) 
			{
				correctAnswerresulttext.text = "" + userAnswer + " is correct!"; //Displays results on screen for user.
				green.SetActive (true);
				red.SetActive (false);
				wrongAnswerresulttext.text = "";
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
				wrongAnswerresulttext.text = "" + userAnswer + " is incorrect! The correct answer is: " + currentQA.answers [0] + "";
				red.SetActive (true);
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
		correctAnswerresulttext.text = "";
		green.SetActive (false);
	}

	public void GoGoBananas ()
	{
		startButton.SetActive (false);
		blurStart.SetActive (false);
	}
}