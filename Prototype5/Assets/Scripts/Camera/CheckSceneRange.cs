using UnityEngine;
using System.Collections;

public class CheckSceneRange : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//DEFINE THE RANGE OF EACH SCENE

		//Scene Credit
		if(transform.position.x>-746.0f && transform.position.x<-741.0f && transform.position.y>41.0f && transform.position.y<46.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, -744f, -743.5f);
			pos.y = Mathf.Clamp (pos.y, 42f, 43f);
			transform.position = pos;
		}

		//Scene Title
		if(transform.position.x>-746.0f && transform.position.x<-741.0f && transform.position.y>16.0f && transform.position.y<23.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, -744f, -743.5f);
			pos.y = Mathf.Clamp (pos.y, 18f, 19f);
			transform.position = pos;
		}

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

		//Scene03.1
		if(transform.position.x>500.0f && transform.position.x<525.0f && transform.position.y>-998.0f && transform.position.y<-990.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, 508.0f, 522.0f);
			pos.y = Mathf.Clamp (pos.y, -995.5f, -992f);
			transform.position = pos;
		}

		//Scene03.2
		if(transform.position.x>605.0f && transform.position.x<618.0f && transform.position.y>-1097.0f && transform.position.y<-1090.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, 608.0f, 613.0f);
			pos.y = Mathf.Clamp (pos.y, -1095.5f, -1092f);
			transform.position = pos;
		}

		//Scene06
		if(transform.position.x>704.0f && transform.position.x<717.0f && transform.position.y>-1197.0f && transform.position.y<-1190.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, 707.5f, 714.5f);
			pos.y = Mathf.Clamp (pos.y, -1195.5f, -1192f);
			transform.position = pos;
		}

		//Scene12.1
		if(transform.position.x>806.0f && transform.position.x<825.0f && transform.position.y>-1297.0f && transform.position.y<-1290.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, 808.5f, 823f);
			pos.y = Mathf.Clamp (pos.y, -1295.5f, -1292f);
			transform.position = pos;
		}

		//Scene07.3 Indoor
		if(transform.position.x>205.0f && transform.position.x<225.0f && transform.position.y>-743.0f && transform.position.y<-735.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, 208.0f, 221.0f);
			pos.y = Mathf.Clamp (pos.y, -740f, -738f);
			transform.position = pos;
		}

		//Scene07.3 Outside
		if(transform.position.x>304.0f && transform.position.x<324.0f && transform.position.y>-913.0f && transform.position.y<-900.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, 310.0f, 320.0f);
			pos.y = Mathf.Clamp (pos.y, -912f, -904.5f);
			transform.position = pos;
		}

		//Scene07.3 Outside When Back
		if(transform.position.x>304.0f && transform.position.x<324.0f && transform.position.y>-965.0f && transform.position.y<-953.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, 310.0f, 320.0f);
			pos.y = Mathf.Clamp (pos.y, -963f, -955.5f);
			transform.position = pos;
		}

		//Scene07.3 Basement
		if(transform.position.x>405.0f && transform.position.x<420.0f && transform.position.y>-1057.0f && transform.position.y<-1037.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, 410.0f, 417.0f);
			pos.y = Mathf.Clamp (pos.y, -1055f, -1040f);
			transform.position = pos;
		}

		//Scene08.3 Indoor
		if(transform.position.x>5.0f && transform.position.x<26.0f && transform.position.y>90.0f && transform.position.y<97.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, 8.0f, 23.0f);
			pos.y = Mathf.Clamp (pos.y, 92f, 95.5f);
			transform.position = pos;
		}

		//Scene08.3 Indoor -Back
		if(transform.position.x>5.0f && transform.position.x<26.0f && transform.position.y>67.0f && transform.position.y<73.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, 8.0f, 23.0f);
			pos.y = Mathf.Clamp (pos.y, 69f, 71.5f);
			transform.position = pos;
		}

		//Scene08.3 Outside
		if(transform.position.x>5.0f && transform.position.x<26.0f && transform.position.y>127.0f && transform.position.y<138.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, 8.0f, 23.0f);
			pos.y = Mathf.Clamp (pos.y, 129.5f, 135f);
			transform.position = pos;
		}

		//Scene08.3 Outside -Back
		if(transform.position.x>5.0f && transform.position.x<26.0f && transform.position.y>165.0f && transform.position.y<175.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, 8.0f, 23.0f);
			pos.y = Mathf.Clamp (pos.y, 166.5f, 173f);
			transform.position = pos;
		}

		//Scene08.3 Basement
		if(transform.position.x>5.0f && transform.position.x<26.0f && transform.position.y>203.0f && transform.position.y<222.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, 8.0f, 20.0f);
			pos.y = Mathf.Clamp (pos.y, 205.5f, 219.5f);
			transform.position = pos;
		}

		//Scene08.2 Indoor
		if(transform.position.x>106.0f && transform.position.x<124.0f && transform.position.y>242.0f && transform.position.y<248.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, 108.0f, 121.0f);
			pos.y = Mathf.Clamp (pos.y, 245.5f, 247.6f);
			transform.position = pos;
		}

		//Scene08.2 Outside
		if(transform.position.x>106.0f && transform.position.x<124.0f && transform.position.y>272.0f && transform.position.y<281.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, 108.0f, 121.0f);
			pos.y = Mathf.Clamp (pos.y, 273.5f, 280f);
			transform.position = pos;
		}

		//Scene08.1 Indoor
		if(transform.position.x>206.0f && transform.position.x<224.0f && transform.position.y>402.0f && transform.position.y<408.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, 208.0f, 221.0f);
			pos.y = Mathf.Clamp (pos.y, 405f, 407.6f);
			transform.position = pos;
		}

		//Scene08.1 Outside
		if(transform.position.x>206.0f && transform.position.x<224.0f && transform.position.y>432.0f && transform.position.y<442.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, 208.0f, 221.0f);
			pos.y = Mathf.Clamp (pos.y, 434f, 440f);
			transform.position = pos;
		}
			
	}
}
