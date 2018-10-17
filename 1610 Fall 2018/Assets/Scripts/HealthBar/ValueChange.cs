using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class ValueChange : ScriptableObject
{

	public FloatData Data;

	public void AddValue (FloatData data)
	{
		Data.Value += data.Value;
	}

	public void SubtractValue (FloatData data)
	{
		Data.Value -= data.Value;
	}
}
