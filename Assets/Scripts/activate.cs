using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class activate : MonoBehaviour 
{
	public GameObject imageOn;
	public Button setUninteractable;
	public GameObject checkMarkNum;

	public void Activate () 
	{
		imageOn.SetActive (true);
		setUninteractable.interactable = false;
		checkMarkNum.SetActive (true);
	}
}
