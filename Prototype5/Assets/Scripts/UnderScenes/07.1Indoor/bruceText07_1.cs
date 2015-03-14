using UnityEngine;
using System.Collections;

public class bruceText07_1 : MonoBehaviour {

	string dialogue = "There’s something wrong with your mom.";
	
	// Update is called once per frame
	void Update () {
		string textBuffer = dialogue;
		if (dialogue == "There’s something wrong with your mom.") {
			textBuffer +="\nGo outside and look for her.";
			textBuffer +="\nI’ll wait for her here. ";
			textBuffer +="\nShe might be back. ";
		}
		GetComponent<TextMesh>().text = textBuffer;
	}
}
