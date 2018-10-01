using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class IfStatement : MonoBehaviour
{

	public bool LightOn;
	public string Password;
	public int A, B, C;
	
	public FloatData WizardPower, PawnPower;
	public NameID Lock, Key;
	
	
	
	void Update () {

		if (Lock == Key)
		{
			print("OpenDoor");
		}
		
		if (LightOn)
		{
			print("The light is on.");
		}
		else
		{
			print("The light is off");
		}

		if (WizardPower.Value > PawnPower.Value)
		{
			print("Wizard Wins");
		}
		
		
		

		if (Password == "ou812")
		{
			print("you are correct");
		}

		if (C == B+A)
		{
			print(C);
		}

	
		
		
		
		
		
	}
}
