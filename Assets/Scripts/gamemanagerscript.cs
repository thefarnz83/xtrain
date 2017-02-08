using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

public class gamemanagerscript : MonoBehaviour 
{
	public GameObject tabletInterface;
	public int scoreValue;
	public int buttonCount;
	public scoremanagertest scoreAccess; //This is so the question control can have access to the scoremanager.
	public Text answerresulttext; //This displays after every answer input informing the user of right or wrong answer.
	[Serializable] // makes this able to be shown in the inspector if all fields are standard types
	public class QuestionAnswerSet 
	{
		// this class defines one question, and a list of answers
		public string question;
		public List<string> answers;
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

		answerresulttext.text = "";
	}

	void Update ()
	{
		userInputField.text = userInputField.text.ToUpper ();

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
		string[] userAnswers = userInputField.text.Split(',');

		bool correct = false;

		// if any of their answers matches one in the question/answer set, it's correct
		foreach(string userAnswer in userAnswers) 
		{
			if (currentQA.answers.Contains (userAnswer)) 
			{
				correct = true;
				Debug.Log (userAnswer);
				print ("User answer: '" + userAnswer + "' is correct!");
				answerresulttext.text = "'" + userAnswer + "' is correct!";
				tabletInterface.SetActive (false);
				scoreAccess.AddScore (scoreValue);
				scoreAccess.AddButtonCount (buttonCount);
				break;
			}
			//---------------- GameIdea ---------------------------

			else 
			{
				Debug.Log (userAnswer);
				answerresulttext.text = "'" + userAnswer + "' is incorrect! The correct answer is: '" + currentQA.answers [0] + "'";
				//tabletInterface.SetActive (false);
				//scoreAccess.AddButtonCount (buttonCount);
				print ("User answer: '" + userAnswer + "' is incorrect! The correct answer is: '" + currentQA.answers[0] + /*"," + currentQA.answers[1] + */"'");

				//---------------------------idea----------------------------------

			}
		}

		/*////////////////////////////////////////////////////////////////////////////
		///                           Redundent Below                              ///
		//////////////////////////////////////////////////////////////////////////////

		if(correct) 
		{
			// do stuff
			tabletInterface.SetActive (false);
			scoreAccess.AddScore (scoreValue);
			print("Done, Done, Done");
			//print (userAnswers);
			//NextQuestion();
		}
		else 
		{
			// do other stuff
			print("User answers are incorrect");
			//print (userAnswers);

		}*/
	}

	public void SetQuestion(int index)
	{
		currentQAIndex = index;
		currentQA = questionAnswerList[currentQAIndex];
	}

	//---------------- Idea ---------------------------

	public void ActivateSystem ()
	{
		tabletInterface.SetActive (true);
	}
}