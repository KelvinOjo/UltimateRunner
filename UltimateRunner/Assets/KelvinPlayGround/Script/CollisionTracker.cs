using UnityEngine;
using System.Collections;

public class CollisionTracker : MonoBehaviour {


	public UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl control;
	public UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl control2;

	private float timer = 5.0f;
	private float timer2 = 5.0f;
	private bool startTime = false;
	private bool startTime2 = false;


	public GameObject Player;
	
	public GameObject Player2;



	void Awake(){
		
		Player = GameObject.Find ("Player1");
		Player2 = GameObject.Find ("Player2");



	}

	void Start()
	{


	}



	void OnTriggerEnter(Collider coll){

		if (coll.gameObject == Player) 
		{
			control.SetRunningSpeed_SLOW ();
			startTime = true;
			Debug.Log (gameObject.name +" was triggered by[Small wall hit]" + coll.gameObject.name);
		}

		if (coll.tag == "player2") 
		{
			control2.SetRunningSpeed_SLOW ();
			startTime2 = true;
			Debug.Log (gameObject.name +" was triggered by[Small wall hit]" + coll.gameObject.name);
		}






	}



	// Update is called once per frame
	void Update () {

		p1timmer ();
		p2timmer ();

	
	}


	void p1timmer()
	{

		//timer -= Time.deltaTime;
		if(startTime == true)
		{
			timer -= Time.deltaTime;
			Debug.Log(timer + "coll timmmmer");
		}
		if(timer <= 0){
			
			startTime = false;
			timer = 5.0f;
			control.SetRunningSpeed_FAST();
		}

	}

	void p2timmer()
	{
		
		//timer -= Time.deltaTime;
		if(startTime2 == true)
		{
			timer2 -= Time.deltaTime;
			Debug.Log(timer2 + "coll palyer 2 timmmmer");
		}
		if(timer2 <= 0){
			
			startTime2 = false;
			timer2 = 5.0f;
			control2.SetRunningSpeed_FAST();
		}
		
	}




}
