using UnityEngine;
using System.Collections;

public class bruceText07_3 : MonoBehaviour {

	string dialogue = "Something might happened to her!";
	
	// Update is called once per frame
	void Update () {
		string textBuffer = dialogue;
		if (dialogue == "Something might happened to her!") {
			textBuffer +="\nWe should go outside to find her.";
		}
		GetComponent<TextMesh>().text = textBuffer;
	}
}
