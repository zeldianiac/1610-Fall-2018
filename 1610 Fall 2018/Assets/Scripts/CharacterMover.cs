using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{

	public CharacterController Controller;

	public float MoveSpeed = 3.0f;
	
	private Vector3 position;
	private Vector3 rotation;

	// Use this for initialization
	void Start ()
	{
		Controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
			position.Set(MoveSpeed*Input.GetAxis("Horizontal"), MoveSpeed*Input.GetAxis("Vertical"), 0);
			transform.Rotate(rotation);
			position = transform.TransformDirection(position);
		Controller.Move(position * Time.deltaTime);
	}
}
