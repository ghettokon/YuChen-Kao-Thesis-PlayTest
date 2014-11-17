using UnityEngine;
using System.Collections;

public class StartScenePhoneText : MonoBehaviour {

	string dialogue = "You have one voice mail.";
	
	// Update is called once per frame
	void Update () {
		string textBuffer = dialogue;
		if (dialogue == "You have one voice mail.") {
			textBuffer +="\nThis is Alex.";
			textBuffer +="\nI got what you want,";
			textBuffer +="\ncall back to me.";
		}
		GetComponent<TextMesh>().text = textBuffer;
	}
}
