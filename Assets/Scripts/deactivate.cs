using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class deactivate : MonoBehaviour 
{
	public GameObject imageOff;
	public Button setUninteractable;
	public GameObject checkMarkNum;

	public void Deactivate () 
	{
		imageOff.SetActive (false);
		setUninteractable.interactable = false;
		checkMarkNum.SetActive (true);
	}
}
