using UnityEngine;
using System.Collections;

public class Cristalsound : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	void Cristalplay(){

		GetComponent<AudioSource>().Play();
	}

}
