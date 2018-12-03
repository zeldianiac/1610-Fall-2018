using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlatMovement : MonoBehaviour {

	public CharacterController Controller;
	
	// Use this for initialization
	void Start ()
	{
		Controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
