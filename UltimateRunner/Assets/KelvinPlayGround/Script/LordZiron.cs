using UnityEngine;
using System.Collections;

public class LordZiron : MonoBehaviour {




	private float timer = 10.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		timer -= Time.deltaTime;
		evilTimer ();



	
	}



	void evilTimer(){

		if (timer <= 0) {
			GetComponent<AudioSource>().Play();
			timer = 10.0f + 7.0f;



		}


	}
}
