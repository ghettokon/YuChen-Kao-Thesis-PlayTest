using UnityEngine;
using System.Collections;

public class StartSceneBruceText : MonoBehaviour {

	string dialogue = "Where is Mary and Zoe?";
	
	// Update is called once per frame
	void Update () {
		string textBuffer = dialogue;
		if (dialogue == "Where is Mary and Zoe?") {
			textBuffer +="\nWe suppose to have dinner tonight.";
		}
		GetComponent<TextMesh>().text = textBuffer;
	}
}
