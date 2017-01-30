using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems; // Required when using Event data.
using System.Collections.Generic;

public class questionmanager : MonoBehaviour
{
	public int questionReference;
	public GameObject tabletInterface;
	//public scoremanager scoreAccess; //Needed to get access to the scoremanager.
	static List<GameObject> colliderThings = new List<GameObject> (); //Register the game objects with colliders.
	public GameObject inactiveButton;
	public GameObject checkMarkNumber;
	//public GameObject imageToTurnOff;

	void Start ()
	{
		colliderThings.Add (gameObject);
	}

	void OnMouseDown ()
	{
		gamemanager.setquestion (questionReference);
		tabletInterface.SetActive (true);
		inactiveButton.SetActive (false);
		checkMarkNumber.SetActive (true);
		//imageToTurnOff.SetActive (false);
		GetComponent<Collider> ().enabled = false; //Not Box Collider since the light is a sphere.
		colliderThings.Remove(gameObject); //Remove the game objects from the register list when they have been clicked on.
		if (colliderThings.Count == 0) 
		{
			//GameOver ();
			//Debug.Log ("Game Over");
		}
		Debug.Log ("You selected the " + transform + " transform");
	}
}