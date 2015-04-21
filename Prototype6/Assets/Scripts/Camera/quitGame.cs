using UnityEngine;
using System.Collections;

public class quitGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("escape")) {
			//Application.Quit ();
			//transform.position = new Vector3(-744.0f, 20.0f, 16.0f);
			Application.LoadLevel(0);
		}
	}
}
