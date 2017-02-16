using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class activatesub : MonoBehaviour 
{
	public GameObject imageOn;
	public Button setInteractableOne, setsetInteractableTwo;
	public Image one;
	public Image two;
	public Button disableWhenDone;


	//--------------------- image info ----------------------
	public GameObject turnThisOff; //dont need this here. Added in deactivate script as Gameobject imageOff

	public void Activate ()
	{
		imageOn.SetActive (true);
		setInteractableOne.interactable = true;
		setsetInteractableTwo.interactable = true;
	}

	void Update ()
	{
		if (one.enabled == true && two.enabled == true) 
		{
			imageOn.SetActive (false);
			one.enabled = false;
			two.enabled = false;
			//turnThisOff.SetActive (false); //dont need this here. Added in deactivate script as Gameobject imageOff
			disableWhenDone.interactable = false;
		}
	}
}
