using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class activatemultiple : MonoBehaviour 
{
	public GameObject imageOn;
	public Button setUninteractable;
	public Button setUninteractable2;
	public Button setUninteractable3;
	public GameObject checkMarkNum;

	public void Activate () 
	{
		imageOn.SetActive (true);
		setUninteractable.interactable = false;
		setUninteractable2.interactable = false;
		setUninteractable3.interactable = false;
		checkMarkNum.SetActive (true);
	}
}
