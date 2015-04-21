using UnityEngine;
using System.Collections;

public class ghostText02L : MonoBehaviour {

	string dialogue = "This was the day,";
	
	// Update is called once per frame
	void Update () {
		string textBuffer = dialogue;
		if (dialogue == "This was the day,") {
			textBuffer +="\nbut there was noyhing I could do...";
		}
		GetComponent<TextMesh>().text = textBuffer;
	}
}
