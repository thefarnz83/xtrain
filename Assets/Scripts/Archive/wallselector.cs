using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class wallselector : MonoBehaviour 
{	/*
	public Button cleanWalls;
	public Button paintWalls;
	public Image wallOptions;
	public Image X30;
	public Image X40;
	//public BoxCollider cleanWallsCollider;
	//public BoxCollider paintWallsCollider;
	public BoxCollider wallSelectorCollider;
	public GameObject imageToDisable;

	void Start () 
	{
		cleanWalls.interactable = false;
		paintWalls.interactable = false;
		wallOptions.enabled = false;
		//X30.enabled = false;
		//X40.enabled = false;
	}

	void OnMouseDown ()
	{
		cleanWalls.interactable = true;
		paintWalls.interactable = true;
		wallOptions.enabled = true;
	}

	void Update () 
	{
		/*if (cleanWallsCollider.enabled == false) 
		{
			X30.enabled = true;
		}

		if (paintWallsCollider.enabled == false) 
		{
			X40.enabled = true;
		}

		if (X30.enabled == true && X40.enabled == true) 
		{
			wallOptions.enabled = false;
			wallSelectorCollider.enabled = false;
			wallOptions.enabled = false;
			X30.enabled = false;
			X40.enabled = false;
			imageToDisable.SetActive (false);
		}
	}*/




	public Button cleanWalls;
	public Button paintWalls;
	public Image wallOptions;
	public Image X30;
	public Image X40;
	public BoxCollider cleanWallsCollider;
	public BoxCollider paintWallsCollider;
	public BoxCollider wallSelectorCollider;
	public GameObject imageToDisable;

	void Start () 
	{
		cleanWalls.interactable = false;
		paintWalls.interactable = false;
		wallOptions.enabled = false;
		X30.enabled = false;
		X40.enabled = false;
	}

	void OnMouseDown ()
	{
		cleanWalls.interactable = true;
		paintWalls.interactable = true;
		wallOptions.enabled = true;
	}

	void Update () 
	{
		if (cleanWallsCollider.enabled == false) 
		{
			X30.enabled = true;
		}

		if (paintWallsCollider.enabled == false) 
		{
			X40.enabled = true;
		}

		if (cleanWallsCollider.enabled == false && paintWallsCollider.enabled == false) 
		{
			wallOptions.enabled = false;
			wallSelectorCollider.enabled = false;
			wallOptions.enabled = false;
			X30.enabled = false;
			X40.enabled = false;
			imageToDisable.SetActive (false);
		}
	}

}
