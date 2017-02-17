using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class activatesub : MonoBehaviour 
{
	public GameObject imageOn;
	public Button setInteractableOne, setsetInteractableTwo;
	public Image one;
	public Image two;
	public Button disableWhenClicked;
	public Button disableWhenClicked2;
	public Button disableWhenClicked3;

	public void Activate ()
	{
		imageOn.SetActive (true);
		setInteractableOne.interactable = true;
		setsetInteractableTwo.interactable = true;
		disableWhenClicked.interactable = false;
		disableWhenClicked2.interactable = false;
		disableWhenClicked3.interactable = false;
	}

	void Update ()
	{
		if (one.enabled == true && two.enabled == true) 
		{
			imageOn.SetActive (false);
			one.enabled = false;
			two.enabled = false;
		}
	}
}
