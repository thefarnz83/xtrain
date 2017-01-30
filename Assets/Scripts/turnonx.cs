using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class turnonx : MonoBehaviour 
{
	public Image one;
	public Image two;

	public void ActivateOne ()
	{
		one.enabled = true;
	}

	public void ActivateTwo ()
	{
		two.enabled = true;
	}
}
