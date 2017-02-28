using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class activate : MonoBehaviour
{
	public GameObject imageOn;
	public GameObject imageOff;
	public Button setUninteractable;
	public GameObject checkMarkNum;
	public Button roomButton;
	public gamemanagerscript gamemanageraccess;
	public Text currentQuestion;

	public void Activate ()
	{
		imageOn.SetActive (true);
		setUninteractable.interactable = false;
		checkMarkNum.SetActive (true);
		roomButton.interactable = false;
		currentQuestion.text = gamemanageraccess.currentQA.question;
	}

	public void Deactivate () 
	{
		imageOff.SetActive (false);
		setUninteractable.interactable = false;
		checkMarkNum.SetActive (true);
		roomButton.interactable = false;
		currentQuestion.text = gamemanageraccess.currentQA.question;
	}
}
