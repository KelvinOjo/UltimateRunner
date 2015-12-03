using UnityEngine;
using System.Collections;

public class FallAudio : MonoBehaviour {




	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {

	
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "player" ) 
		{
			GetComponent<AudioSource>().Play();
			//AudioSource.PlayClipAtPoint (fallsound);

		}
		
		if (other.tag == "player2") {

			GetComponent<AudioSource>().Play();
			//AudioSource.PlayClipAtPoint (fallsound);
			
		}
		
		
		
	}




}
