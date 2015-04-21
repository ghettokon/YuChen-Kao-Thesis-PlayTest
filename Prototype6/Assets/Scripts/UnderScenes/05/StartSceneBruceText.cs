using UnityEngine;
using System.Collections;

public class StartSceneBruceText : MonoBehaviour {

	string dialogue = "Where are Mary and Zoe?";
	
	// Update is called once per frame
	void Update () {
		string textBuffer = dialogue;
		if (dialogue == "Where are Mary and Zoe?") {
			textBuffer +="\nWe were supposeed to have dinner out tonight.";
		}
		GetComponent<TextMesh>().text = textBuffer;
	}
}
