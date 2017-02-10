using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class highLightControl : MonoBehaviour 
{
	public GameObject buttonObject;
	public GameObject checkMarkNum;

	void Update () 
	{
		if (buttonObject.activeInHierarchy == true) 
		{
			checkMarkNum.SetActive (true);
		}

		else 
		{
			checkMarkNum.SetActive (false);
		}
	}
}
