using UnityEngine;
using System.Collections;

public class conversation : MonoBehaviour {

	//public Color OnMouseOverColor = Color.yellow;
	string Answer = "I was witness to the murder.";
	
	// Update is called once per frame
	void Update () {
		string textBuffer = Answer;

		if (Answer == "I was witness to the murder.") {
			textBuffer +="\n\n\n[1]What happened when you in the Bill's House?";
			textBuffer +="\n[2]What was your relationship with Bill?";

			if(Input.GetKeyDown(KeyCode.Alpha1)){
				Answer = "That was Sunday Night,";
			}else if (Input.GetKeyDown(KeyCode.Alpha2)){
				Answer = "My mother was a housekeeper with Bill.";
			}
		}

		if (Answer == "That was Sunday Night,") {
			textBuffer +="\nabout 9 pm.";
			if(Input.GetKeyDown(KeyCode.R)){
				Answer = "I was witness to the murder.";
			}
		}

		if (Answer == "My mother was a housekeeper with Bill.") {
			textBuffer +="\nWe know each other since I was a child.";
			if(Input.GetKeyDown(KeyCode.R)){
				Answer = "I was witness to the murder.";
			}
		}

		GetComponent<TextMesh>().text = textBuffer;
	}

//	void OnMouseOver(){
//		GetComponent<TextMesh> ().color = OnMouseOverColor;
//	}
}
