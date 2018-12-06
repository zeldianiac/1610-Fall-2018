using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class Instancing : MonoBehaviour
{

	public GameObject Instance;

	// ASK ROMWELL ON THIS
	public void Create()
	
		
		{
			Instantiate(Instance, transform.position, transform.rotation);

		}


	}

	
