﻿using UnityEngine;

public class UpdateAnims : MonoBehaviour
{

	private Animator anims;
	public float Speed;
	
	void Start ()
	{
		anims = GetComponent<Animator>();
	}
	
	void Update ()
	{
		anims.SetFloat("Speed", Speed);
	}
}
