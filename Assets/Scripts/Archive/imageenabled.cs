using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class imageenabled : MonoBehaviour 
{
	public Image xNumber;

	void OnClick ()
	{
		xNumber.enabled = true;
	}
}