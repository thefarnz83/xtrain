using UnityEngine;
using System.Collections;

public class delegatetestbathroom : MonoBehaviour 
{
	/*delegate void myDelegate(string[] answers);
	private myDelegate mydelegate;

	// Use this for initialization
	void Start () 
	{
		mydelegate += PrintIt;
		mydelegate (50);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void PrintIt (string[] answers)
	{
		print (answers);
	}*/

	public delegate void CommentMethod(string text);

	//Runs once at the start of the program
	void Start() {

		CommentMethod cm = Say;

		//Removing the parameter of 'string' in the delegate and the 'string' of Say method
		//and then trying to use the method BELOW, it works. But otherwise WITH parameters it won't.
		WriteText(cm, string.Empty); // This would work, if the Delegate and Say didn't had a parameter.

		//Doesn't work..
		WriteText(cm, "First Comment");
		WriteText(cm, "Second comment");
	}

	//Function to simple Debug Log a comment
	public void Say(string comment) {
		Debug.Log(comment);
	}

	//Gets an input of a delegate of type void, then uses it between two Debug Logs
	public void WriteText(CommentMethod method, string comment) {
		Debug.Log("START");
		method(comment);
		Debug.Log("END");
	}
}
