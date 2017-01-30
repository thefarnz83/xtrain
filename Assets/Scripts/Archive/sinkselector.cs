using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class sinkselector : MonoBehaviour 
{
	public Button resetSink;
	public Button cleanSink;
	public Image sinkOptions;
	public Image X10;
	public Image X20;
	public BoxCollider resetSinkCollider;
	public BoxCollider cleanSinkCollider;
	public BoxCollider sinkSelectorCollider;

	void Start () 
	{
		sinkOptions.enabled = false;
		X10.enabled = false;
		X20.enabled = false;
	}

	void OnMouseDown ()
	{
		sinkOptions.enabled = true;
		resetSink.interactable = true;
		cleanSink.interactable = true;
	}

	void Update () 
	{
		if (resetSinkCollider.enabled == false) 
		{
			X10.enabled = true;
		}

		if (cleanSinkCollider.enabled == false) 
		{
			X20.enabled = true;
		}

		if (resetSinkCollider.enabled == false && cleanSinkCollider.enabled == false) 
		{
			sinkOptions.enabled = false;
			X10.enabled = false;
			X20.enabled = false;
		}
	}
}
