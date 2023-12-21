using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetConnect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Triangle") || Input.GetKeyDown(KeyCode.K))
		{
			GetComponent<DarkRift.Client.Unity.UnityClient>().DoConnect();
		}
	}
}
