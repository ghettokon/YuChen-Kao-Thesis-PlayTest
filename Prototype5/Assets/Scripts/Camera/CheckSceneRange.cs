﻿using UnityEngine;
using System.Collections;

public class CheckSceneRange : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//DEFINE THE RANGE OF EACH SCENE

		//Scene00
		if(transform.position.x>-770.0f && transform.position.x<-730.0f && transform.position.y>-4.0f && transform.position.y<9.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, -744f, -743.5f);
			pos.y = Mathf.Clamp (pos.y, 2f, 3f);
			transform.position = pos;
		}

		//Scene05
		if(transform.position.x>-650.0f && transform.position.x<600.0f && transform.position.y>-4.0f && transform.position.y<9.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, -592.5f, -580.0f);
			pos.y = Mathf.Clamp (pos.y, 2f, 5f);
			transform.position = pos;
		}
		
		//Scene12.2
		if(transform.position.x>-300.0f && transform.position.x<-270.0f && transform.position.y>-200.0f && transform.position.y<-190.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, -290.0f, -277f);
			pos.y = Mathf.Clamp (pos.y, -197f, -194f);
			transform.position = pos;
		}
		
		//Scene01
		if(transform.position.x>-495.0f && transform.position.x<-477.0f && transform.position.y>-50.0f && transform.position.y<-35.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, -491.0f, -480.0f);
			pos.y = Mathf.Clamp (pos.y, -46f, -43.5f);
			transform.position = pos;
		}

		//Scene02R
		if(transform.position.x>-95.0f && transform.position.x<-75.0f && transform.position.y>-397.0f && transform.position.y<-388.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, -92.0f, -80.0f);
			pos.y = Mathf.Clamp (pos.y, -395.0f, -392.0f);
			transform.position = pos;
		}

		//Scene02L
		if(transform.position.x>-195.0f && transform.position.x<-175.0f && transform.position.y>-295.0f && transform.position.y<-285.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, -192.5f, -177f);
			pos.y = Mathf.Clamp (pos.y, -293.5f, -290.0f);
			transform.position = pos;
		}

		//Scene09
		if(transform.position.x>7.0f && transform.position.x<22.0f && transform.position.y>-500.0f && transform.position.y<-480.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, 12.0f, 18.0f);
			pos.y = Mathf.Clamp (pos.y, -491.0f, -486.0f);
			transform.position = pos;
		}

		//Scene04
		if(transform.position.x>-395.0f && transform.position.x<-370.0f && transform.position.y>-97.0f && transform.position.y<-85.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, -390.5f, -376.0f);
			pos.y = Mathf.Clamp (pos.y, -95f, -91.5f);
			transform.position = pos;
		}

		//Scene11
		if(transform.position.x>104.0f && transform.position.x<120.0f && transform.position.y>-600.0f && transform.position.y<-590.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, 109.0f, 118.0f);
			pos.y = Mathf.Clamp (pos.y, -595f, -592f);
			transform.position = pos;
		}

		//Scene07.1 Indoor
		if(transform.position.x>205.0f && transform.position.x<225.0f && transform.position.y>-698.0f && transform.position.y<-690.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, 208.0f, 221.0f);
			pos.y = Mathf.Clamp (pos.y, -695f, -693f);
			transform.position = pos;
		}

		//Scene07.1 Outside
		if(transform.position.x>304.0f && transform.position.x<324.0f && transform.position.y>-797.0f && transform.position.y<-787.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, 310.0f, 320.0f);
			pos.y = Mathf.Clamp (pos.y, -795f, -789f);
			transform.position = pos;
		}

		//Scene07.1 Outside When Back
		if(transform.position.x>304.0f && transform.position.x<324.0f && transform.position.y>-847.0f && transform.position.y<-835.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, 310.0f, 320.0f);
			pos.y = Mathf.Clamp (pos.y, -845f, -838f);
			transform.position = pos;
		}

		//Scene07.1 Basement
		if(transform.position.x>405.0f && transform.position.x<420.0f && transform.position.y>-895.0f && transform.position.y<-875.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, 410.0f, 417.0f);
			pos.y = Mathf.Clamp (pos.y, -892f, -878f);
			transform.position = pos;
		}


	
	}
}