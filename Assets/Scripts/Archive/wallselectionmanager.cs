using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class wallselectionmanager : MonoBehaviour 
{
	public Button cleanWall, paintWall;
	public Image wallSelector;
	public Image xOne, xTwo, deactivate;
	public GameObject tabletInterface;
	public Collider selectableObject;

	void OnMouseDown ()
	{
		cleanWall.interactable = true;
		paintWall.interactable = true;
		wallSelector.enabled = true;
	}

	void Update ()
	{
		if (xOne.enabled == true && xTwo.isActiveAndEnabled == true) 
		{
			print ("Object Deactivated");
			selectableObject.enabled = false;
			wallSelector.enabled = false;
			cleanWall.interactable = false;
			paintWall.interactable = false;
			xOne.enabled = false;
			xTwo.enabled = false;
			deactivate.enabled = false;
		}
	}
}
