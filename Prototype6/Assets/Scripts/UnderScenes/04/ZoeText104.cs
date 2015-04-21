using UnityEngine;
using System.Collections;

public class ZoeText104 : MonoBehaviour {

	string dialogue = ">Wow, Such a long time!";
	
	// Update is called once per frame
	void Update () {
		string textBuffer = dialogue;
		if (dialogue == ">Wow, Such a long time!") {
			textBuffer +="\nWe may just stay home.";
		}
		GetComponent<TextMesh>().text = textBuffer;
	}
}
