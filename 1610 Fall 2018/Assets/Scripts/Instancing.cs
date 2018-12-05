using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class Instancing : MonoBehaviour
{

	public GameObject Instance;

	// ASK ROMWELL ON THIS
	void Update()
	{
		if (Input.GetMouseButtonDown((int) MouseButton.RightMouse));
		{
			Instantiate(Instance, transform.position, transform.rotation);

		}


	}
}
	
