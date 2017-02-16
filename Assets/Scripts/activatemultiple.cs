using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class activatemultiple : MonoBehaviour 
{
	public GameObject imageOn;
	public GameObject imageOff;
	public Button setUninteractable;
	public Button setUninteractable2;
	public Button setUninteractable3;
	public GameObject checkMarkNum;
	public Button roomButton;


	public void Activate () 
	{
		imageOn.SetActive (true);
		roomButton.interactable = false;
		setUninteractable.interactable = false;
		setUninteractable2.interactable = false;
		setUninteractable3.interactable = false;
		checkMarkNum.SetActive (true);
	}

	public void Deactivate () 
	{
		imageOff.SetActive (false);
		roomButton.interactable = false;
		setUninteractable.interactable = false;
		setUninteractable2.interactable = false;
		setUninteractable3.interactable = false;
		checkMarkNum.SetActive (true);

	}
}
