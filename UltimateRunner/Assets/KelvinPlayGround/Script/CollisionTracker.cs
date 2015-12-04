using UnityEngine;
using System.Collections;

public class CollisionTracker : MonoBehaviour {
	private UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl control;
	private UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl control2;

	private float timer = 5.0f;
	private float timer2 = 5.0f;
	private bool startTime = false;
	private bool startTime2 = false;

	//-----------------------------------------------------
	void Awake(){
		GameObject player1GO = GameObject.FindWithTag ("player");
		GameObject player2GO = GameObject.FindWithTag ("player2");

		control = player1GO.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>();
		control2 = player2GO.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>();
	}

	//-----------------------------------------------------
	void OnTriggerEnter(Collider coll){
		print ("CollisionTracker hit by something tagged: " + coll.tag);

		if (coll.CompareTag("player")) 
		{
			control.SetRunningSpeed_SLOW ();
			startTime = true;
			GetComponent<AudioSource>().Play();
			//Debug.Log (gameObject.name +" was triggered by[Small wall hit]" + coll.gameObject.name);
		}

		if (coll.CompareTag("player2")) 
		{
			control2.SetRunningSpeed_SLOW ();
			startTime2 = true;
			GetComponent<AudioSource>().Play();
			//Debug.Log (gameObject.name +" was triggered by[Small wall hit]" + coll.gameObject.name);
		}
	}

	//-----------------------------------------------------
	void Update () {
		P1timmer ();
		P2timmer ();
	}

	//-----------------------------------------------------
	void P1timmer()
	{
		//timer -= Time.deltaTime;
		if(startTime == true)
		{
			timer -= Time.deltaTime;
			//Debug.Log(timer + "coll timmmmer");
		}
		if(timer <= 0){
			
			startTime = false;
			timer = 5.0f;
			control.SetRunningSpeed_FAST();
		}
	}

	//-----------------------------------------------------
	void P2timmer()
	{
		//timer -= Time.deltaTime;
		if(startTime2 == true)
		{
			timer2 -= Time.deltaTime;
//			Debug.Log(timer2 + "coll palyer 2 timmmmer");
		}
		if(timer2 <= 0){
			
			startTime2 = false;
			timer2 = 5.0f;
			control2.SetRunningSpeed_FAST();
		}
	}
}
