using UnityEngine;
using System.Collections;

public class VictimText07_1 : MonoBehaviour {

	string dialogue = "I hide something.";
	
	// Update is called once per frame
	void Update () {
		string textBuffer = dialogue;
		if (dialogue == "I hide something.") {
			textBuffer +="\nSome disturbing things happened.";
			textBuffer +="\nI want to change it.";
		}
		GetComponent<TextMesh>().text = textBuffer;
	}
}
