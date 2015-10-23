using UnityEngine;
using System.Collections;

public class TrackManager : MonoBehaviour {


	//global variables.

	public GameObject Track1prefab;
	public GameObject currentTrack;

	// Use this for initialization
	void Start () {
		spawnTrack ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void spawnTrack(){

		Instantiate (Track1prefab, currentTrack.transform.GetChild(0).transform.GetChild(1).position,Quaternion.identity);
	}
}
