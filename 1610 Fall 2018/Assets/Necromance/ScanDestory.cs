using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanDestory : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start()
	{
		yield return new WaitForSeconds(1);
		Destroy(gameObject);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
