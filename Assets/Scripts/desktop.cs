using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class desktop : MonoBehaviour 
{
	public GameObject desktopInterface;
	public GameObject answerInput1;
	public GameObject answerInput2;
	public GameObject submitButton;

	public void ActivateTablet ()
	{
		desktopInterface.SetActive (true);
		answerInput1.SetActive (false);
		answerInput2.SetActive (false);
		submitButton.SetActive (false);
	}

	public void DeactivateTablet ()
	{
		desktopInterface.SetActive (false);
		answerInput1.SetActive (true);
		answerInput2.SetActive (true);
		submitButton.SetActive (true);
	}
}
