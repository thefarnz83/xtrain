using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

public class gamemanagercontroller : MonoBehaviour 
{
	public GameObject tabletInterface;
	//public string[] imageOff;
	public int scoreValue;
	public scoremanagertest scoreAccess; //This is so the question control can have access to the scoremanager.
	//---------------- Game Final Score Idea ---------------------------

	//----------------- Original Above --------------------
	[Serializable] // makes this able to be shown in the inspector if all fields are standard types
	public class QuestionAnswerSet 
	{
		// this class defines one question, and a list of answers
		public string question;
		public List<string> answers;
		public string correctAnswers;
		public string userAnswer;
		public bool WasCorrect()
		{
			return (userAnswer.ToUpper () == correctAnswers.ToUpper ());
		}
	}

	// configured in the Inspector
	public List<QuestionAnswerSet> questionAnswerList; // list of question-to-answer sets
	public InputField userInputField; // the input field the user will type in

	private int currentQAIndex; // index of the current question-to-answer set
	private QuestionAnswerSet currentQA; // the current question-to-answer set

	private void Start() 
	{
		// initialize current question to the first in the list
		if(questionAnswerList.Count > 0) 
		{
			currentQA = questionAnswerList[0];
		}
	}

	void Update ()
	{
		userInputField.text = userInputField.text.ToUpper ();
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
		string[] userAnswers = userInputField.text.Split(',');

		bool correct = false;

		// if any of their answers matches one in the question/answer set, it's correct
		foreach(string userAnswer in userAnswers) 
		{
			if(currentQA.answers.Contains(userAnswer)) 
			{
				correct = true;
				print("User answer: '" + userAnswer + "' is correct!");
				break;
			}
		}


		if(correct) 
		{
			// do stuff
			tabletInterface.SetActive (false);
			scoreAccess.AddScore (scoreValue);
			print("Done, Done, Done");
			//NextQuestion();

		}
		else 
		{
			// do other stuff
			print("User answers are incorrect");

		}
	}

	public void SetQuestion(int index){
		currentQAIndex = index;
		currentQA = questionAnswerList[currentQAIndex];
	}

	//---------------- Idea ---------------------------

	public void ActivateSystem ()
	{
		tabletInterface.SetActive (true);
	}
}