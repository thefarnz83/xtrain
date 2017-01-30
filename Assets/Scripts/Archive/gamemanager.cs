using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gamemanager : MonoBehaviour 
{
	public static gamemanager instance;
	public string[] questions; //Array with the questions to go to [saveindex] (old)= {"Fridge", "Stove", "Light", "Door", "BaseMold", "DoubleSink"}
	public string[] answers; //Array with the answers to go to [saveindex] (old)= {"Cold", "Hot", "Bright", "Hard", "Base", "Wet"}
	public int saveindex;
	public InputField questionAnswerField;
	public InputField myInputField = null; //Force Unity to serialize a private field.
	public GameObject tabletInterface;
	public int scoreValue;
	public scoremanager scoreAccess; //This is so the question control can have access to the scoremanager.
	public Button tabletButton;
	public Button roomButton;
	public GameObject inactiveButton; //room button on the tablet view.
	public GameObject submitButton; //question submit button gameobject.
	public GameObject answerInput; //question input field gameobject.
	public GameObject starttext;
	public GameObject blurImage;

	void Start () 
	{
		instance = this; 
	}

	void Update ()
	{
		myInputField.text = myInputField.text.ToUpper (); 
		if (Input.GetKey ("escape"))
			Application.Quit ();
	}

	public void StartTraining ()
	{
		starttext.SetActive (false);
		blurImage.SetActive (false);
	}

	public void ActivateTablet ()
	{
		tabletInterface.SetActive (true);
		answerInput.SetActive (false);
		submitButton.SetActive (false);
	}

	public void DeactivateTablet ()
	{
		tabletInterface.SetActive (false);
		answerInput.SetActive (true);
		submitButton.SetActive (true);
	}

	public void Submit ()
	{
		//public string[] userAnswers = questionAnswerField.text.Split (",");
		if (questionAnswerField.text == answers [saveindex]/* || questionAnswerField.text == answersTwo [saveindex]*/) 
		{
			myInputField.image.color = Color.white; //change background of inputfield to white with right answer.
			tabletInterface.SetActive (false);
			scoreAccess.AddScore (scoreValue);
			myInputField.text = "";
			inactiveButton.SetActive (true); //reactivates room button for the view tablet function 
			Debug.Log ("That is Correct");
		} 

		else if (questionAnswerField.text != answers [saveindex]) 
		{
			myInputField.image.color = Color.red; //change background of inputfield to red with wrong answer.
			myInputField.text = ""; //Make active if you want the input field to clear after wrong input is detected.
			tabletInterface.SetActive (true); //Keep active tablet if wrong answer.
			myInputField.text = "Incorrect. Please try again.";
			Debug.Log ("Wrong");
		}
	}
		
	public static void setquestion (int index)
	{
		gamemanager.instance.saveindex = index;
	}

	public static void setcollider (int index)
	{
		gamemanager.instance.saveindex = index;
	}
}
