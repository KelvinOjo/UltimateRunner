using UnityEngine;
using System.Collections;

public class Endcollider : MonoBehaviour {




	public GameObject Player;
	
	public GameObject Player2;

	private int enter;


	void Awake(){
		
		Player = GameObject.Find ("Player1");
		Player2 = GameObject.Find ("Player2");
	}
	   
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void OnTriggerEnter(Collider other){

		if(other.tag == "player" ){

			enter++;
			print(" p1 end" + enter);

		}

		if (other.tag == "player2") {
			
			enter++;
			print(" p2 end" + enter);

			
		}









	}
}
