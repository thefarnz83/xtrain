using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class deactivatemultiple : MonoBehaviour 
{
	public GameObject imageOff;
	public Button setUninteractable;
	public Button setUninteractable2;
	public Button setUninteractable3;
	public GameObject checkMarkNum;

	public void Deactivate () 
	{
		imageOff.SetActive (false);
		setUninteractable.interactable = false;
		setUninteractable2.interactable = false;
		setUninteractable3.interactable = false;
		checkMarkNum.SetActive (true);
	}
}
