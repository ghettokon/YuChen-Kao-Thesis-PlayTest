using UnityEngine;
using System.Collections;

public class RalphText204 : MonoBehaviour {

	string dialogue = ">Oh, you should try something different!";
	
	// Update is called once per frame
	void Update () {
		string textBuffer = dialogue;
		if (dialogue == ">Oh, you should try something different!") {
			textBuffer +="\nWhat about having a great dinner out!?";
		}
		GetComponent<TextMesh>().text = textBuffer;
	}
}
