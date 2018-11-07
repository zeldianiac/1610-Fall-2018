﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventRepeat : MonoBehaviour
{

	public UnityEvent[] OnRepeat;
	public float WaitForSeconds = 2;
	private int i = 0;

	IEnumerator Start()
	{
		while (true)
		{
			yield return new WaitForSeconds(WaitForSeconds);
			OnRepeat[i].Invoke();
			if (i < OnRepeat.Length-1)
			{
				i++;
			}
			else
			{
				i = 0;
			}
		}
	}
}