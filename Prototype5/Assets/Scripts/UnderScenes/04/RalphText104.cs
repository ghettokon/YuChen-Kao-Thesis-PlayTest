using UnityEngine;
using System.Collections;

public class RalphText104 : MonoBehaviour {

	string dialogue = ">Hey Zoe!";
	
	// Update is called once per frame
	void Update () {
		string textBuffer = dialogue;
		if (dialogue == ">Hey Zoe!") {
			textBuffer +="\nSo happy to see you!";
			textBuffer +="\nAny plans for Christmas Eve?";
		}
		GetComponent<TextMesh>().text = textBuffer;
	}
}
