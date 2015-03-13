using UnityEngine;
using System.Collections;

public class dayNight : MonoBehaviour {

	public GameObject clock;
	public Sprite clockD;
	public Sprite clockN;

	//Day
	public GameObject filterDay;
	public GameObject DayPeople;
	public GameObject fDayLeft;
	public GameObject RalphD;
	public GameObject RalphDT;

	//Day dialogues
	public GameObject peopleA;
	public GameObject peopleB;
	public GameObject peopleC;
	public GameObject peopleD;
	public GameObject peopleAT;
	public GameObject peopleBT;
	public GameObject peopleCT;
	public GameObject peopleDT;


	//Night
	public GameObject filterNight1;
	public GameObject filterNight2;
	public GameObject fNightLeft;
	public GameObject NightLight;
	public GameObject lampL;
	public GameObject RalphN;
	public GameObject ZoeN;
	
	//Night dialogues
	public GameObject RalphNCol1;
	public GameObject RalphNCol2;
	public GameObject RalphT1;
	public GameObject RalphT2;
	public GameObject ZoeNCol1;
	public GameObject ZoeNCol2;
	public GameObject ZoeT1;
	public GameObject ZoeT2_1;
	public GameObject ZoeT2_2;



	public bool isDay = true;

	void OnMouseUpAsButton(){
		isDay = !isDay;
		
		if (isDay) {
			clock.GetComponent<SpriteRenderer> ().sprite = clockD;
			//Day
			filterDay.GetComponent<SpriteRenderer>().enabled = true;
			DayPeople.GetComponent<SpriteRenderer>().enabled = true;
			fDayLeft.GetComponent<SpriteRenderer>().enabled = true;
			RalphD.GetComponent<SpriteRenderer>().enabled = true;
			RalphD.GetComponent<BoxCollider2D>().enabled = true;
			GameObject.Find ("04-RalphDay").GetComponent<MouseClickText> ().turnOff = true;

			//Day dialogues
			peopleA.GetComponent<BoxCollider2D>().enabled = true;
			peopleB.GetComponent<BoxCollider2D>().enabled = true;
			peopleC.GetComponent<BoxCollider2D>().enabled = true;
			peopleD.GetComponent<BoxCollider2D>().enabled = true;
			GameObject.Find ("04-dayPeopleA-collider").GetComponent<MouseClickText> ().turnOff = true;
			GameObject.Find ("04-dayPeopleB-collider").GetComponent<MouseClickText> ().turnOff = true;
			GameObject.Find ("04-dayPeopleC-collider").GetComponent<MouseClickText> ().turnOff = true;
			GameObject.Find ("04-dayPeopleD-collider").GetComponent<MouseClickText> ().turnOff = true;

			//Night
			filterNight1.GetComponent<SpriteRenderer>().enabled = false;
			filterNight2.GetComponent<SpriteRenderer>().enabled = false;
			fNightLeft.GetComponent<SpriteRenderer>().enabled = false;
			NightLight.GetComponent<SpriteRenderer>().enabled = false;
			lampL.GetComponent<SpriteRenderer>().enabled = false;
			RalphN.GetComponent<SpriteRenderer>().enabled = false;
			ZoeN.GetComponent<SpriteRenderer>().enabled = false;

			//Night dialogues
			RalphNCol1.GetComponent<BoxCollider2D>().enabled = false;
			RalphNCol2.GetComponent<BoxCollider2D>().enabled = false;
			RalphT1.GetComponent<BoxCollider2D>().enabled = false;
			RalphT1.GetComponent<MeshRenderer>().enabled = false;
			RalphT2.GetComponent<BoxCollider2D>().enabled = false;
			RalphT2.GetComponent<MeshRenderer>().enabled = false;
			ZoeNCol1.GetComponent<BoxCollider2D>().enabled = false;
			ZoeNCol2.GetComponent<BoxCollider2D>().enabled = false;
			ZoeT1.GetComponent<BoxCollider2D>().enabled = false;
			ZoeT1.GetComponent<MeshRenderer>().enabled = false;
			ZoeT2_1.GetComponent<BoxCollider2D>().enabled = false;
			ZoeT2_1.GetComponent<MeshRenderer>().enabled = false;
			ZoeT2_2.GetComponent<BoxCollider2D>().enabled = false;
			ZoeT2_2.GetComponent<MeshRenderer>().enabled = false;
			GameObject.Find ("04-RalphN-collider1").GetComponent<MouseClickedTextCol> ().turnOff = true;

		} else {
			clock.GetComponent<SpriteRenderer> ().sprite = clockN;
			//Day
			filterDay.GetComponent<SpriteRenderer>().enabled = false;
			DayPeople.GetComponent<SpriteRenderer>().enabled = false;
			fDayLeft.GetComponent<SpriteRenderer>().enabled = false;
			RalphD.GetComponent<SpriteRenderer>().enabled = false;
			RalphD.GetComponent<BoxCollider2D>().enabled = false;
			RalphDT.GetComponent<MeshRenderer>().enabled = false;

			//Day dialogues
			peopleA.GetComponent<BoxCollider2D>().enabled = false;
			peopleB.GetComponent<BoxCollider2D>().enabled = false;
			peopleC.GetComponent<BoxCollider2D>().enabled = false;
			peopleD.GetComponent<BoxCollider2D>().enabled = false;
			peopleAT.GetComponent<MeshRenderer>().enabled = false;
			peopleBT.GetComponent<MeshRenderer>().enabled = false;
			peopleCT.GetComponent<MeshRenderer>().enabled = false;
			peopleDT.GetComponent<MeshRenderer>().enabled = false;

			//Night
			filterNight1.GetComponent<SpriteRenderer>().enabled = true;
			filterNight2.GetComponent<SpriteRenderer>().enabled = true;
			fNightLeft.GetComponent<SpriteRenderer>().enabled = true;
			NightLight.GetComponent<SpriteRenderer>().enabled = true;
			lampL.GetComponent<SpriteRenderer>().enabled = true;
			RalphN.GetComponent<SpriteRenderer>().enabled = true;
			ZoeN.GetComponent<SpriteRenderer>().enabled = true;
			RalphNCol1.GetComponent<BoxCollider2D>().enabled = true;

		}
	}
}
