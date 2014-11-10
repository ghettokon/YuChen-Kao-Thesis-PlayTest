using UnityEngine;
using System.Collections;

public class StartSceneVictimText : MonoBehaviour {

	string dialogue = "I am Bruce.";
	
	// Update is called once per frame
	void Update () {
		string textBuffer = dialogue;
		if (dialogue == "I am Bruce.") {
			textBuffer +="\nIt is one day before that day.";
			textBuffer +="\nI will be killed";
			textBuffer +="\nMaybe...";
		}
		GetComponent<TextMesh>().text = textBuffer;
	}
}
