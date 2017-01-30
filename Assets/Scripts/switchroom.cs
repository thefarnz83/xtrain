using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class switchroom : MonoBehaviour
{
	public float yRotationKitchen = 0.0f;
	public float yRotationNook = 0.0f;
	public float yRotationStart = 0.0f;
	public GameObject imgKitchen, imgNook;
	public GameObject buttonKitchen, buttonNook;

	void Start ()
	{
		yRotationStart += Input.GetAxis("Horizontal");
		transform.eulerAngles = new Vector3(0, yRotationStart, 0);
		imgKitchen.SetActive (true);
		imgNook.SetActive (false);
		buttonKitchen.SetActive (true);
		buttonNook.SetActive (false);
	}

	public void ShowKitchenView () 
	{
		yRotationKitchen += Input.GetAxis("Horizontal");
		transform.eulerAngles = new Vector3(0, yRotationKitchen, 0);
		if (yRotationKitchen == yRotationKitchen) 
		{
			imgKitchen.SetActive (true);
			imgNook.SetActive (false);
			buttonKitchen.SetActive (true);
			buttonNook.SetActive (false);
		}
	}

	public void ShowBreakfastNookView () 
	{
		yRotationNook += Input.GetAxis("Horizontal");
		transform.eulerAngles = new Vector3(0, yRotationNook, 0);

		if (yRotationNook == yRotationNook) 
		{
			imgNook.SetActive (true);
			imgKitchen.SetActive (false);
			buttonNook.SetActive (true);
			buttonKitchen.SetActive (false);
		}
	}
}
