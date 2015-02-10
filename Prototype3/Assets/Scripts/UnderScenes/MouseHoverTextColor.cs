using UnityEngine;
using System.Collections;

public class MouseHoverTextColor : MonoBehaviour {

	public GameObject text;
	public Color whiteColor = new Color32 (255, 255, 255, 255);
	public Color grayColor = new Color32(110, 110, 110, 255);

	void OnMouseEnter(){
		text.renderer.material.color = grayColor;
	}
	
	void OnMouseExit(){
		text.renderer.material.color = whiteColor;
	}

}
