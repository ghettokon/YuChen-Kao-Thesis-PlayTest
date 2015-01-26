using UnityEngine;
using System.Collections;

public class StartScenePhoneText : MonoBehaviour {

	string dialogue = "You have one voice mail.";
	
	// Update is called once per frame
	void Update () {
		string textBuffer = dialogue;
		if (dialogue == "You have one voice mail.") {
			textBuffer +="\nHey.";
			textBuffer +="\nDon't wait for me.";
		}
		GetComponent<TextMesh>().text = textBuffer;
	}
}
