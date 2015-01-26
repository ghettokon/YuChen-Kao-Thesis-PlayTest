using UnityEngine;
using System.Collections;

public class AutoType : MonoBehaviour {

	public float letterPause = 0.1f;

	string message;

	// Use this for initialization
	void Start () {
		message = GetComponent<TextMesh>().text;
		GetComponent<TextMesh>().text = "";
		StartCoroutine(TypeText ());

	}

	void Update(){

	}

	IEnumerator TypeText () {
		foreach (char letter in message.ToCharArray()) {
			GetComponent<TextMesh>().text += letter;
			yield return 0;
			yield return new WaitForSeconds (letterPause);
		}      
	}

}
