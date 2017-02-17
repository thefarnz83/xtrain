using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class overlay : MonoBehaviour 
{
	public GameObject informationImage;
	public Button informationButton;
	public Button exitInformationButton;
	public GameObject overlayImage;
	public Button deactivateRoomSwitch;

	void Start ()
	{
		overlayImage.SetActive (false);
		informationImage.SetActive (true);
		exitInformationButton.interactable = false;
		informationButton.interactable = true;
	}

	public void Activate ()
	{
		overlayImage.SetActive (true);
		informationImage.SetActive (false);
		exitInformationButton.interactable = true;
		informationButton.interactable = false;
		deactivateRoomSwitch.interactable = false;
	}

	public void Deactivate ()
	{
		overlayImage.SetActive (false);
		informationImage.SetActive (true);
		exitInformationButton.interactable = false;
		informationButton.interactable = true;
		deactivateRoomSwitch.interactable = true;

	}
}
