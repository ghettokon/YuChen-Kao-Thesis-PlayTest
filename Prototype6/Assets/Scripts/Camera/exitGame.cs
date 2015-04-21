using UnityEngine;
using System.Collections;

public class exitGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	void OnMouseUpAsButton(){
		Application.Quit ();
	}
}
