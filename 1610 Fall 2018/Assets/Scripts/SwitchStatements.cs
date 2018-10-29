using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SwitchStatements : MonoBehaviour
{

	public GameStates.States GameState;

	public UnityEvent Starting, Loading, Playing, Ending, Dying, Team1Score, Team2Score;

	public void ChangeState(GameStates.States state)
	{
		GameState = state;
	}
	
	// Update is called once per frame
	void Update () {
		switch (GameState)
		{
				case GameStates.States.Starting:
					print("We are starting");
					break;
				
				case GameStates.States.Playing:
					print("We are playing the game.");
					break;
				case GameStates.States.Ending:
					print("We are ending the game. You probably lost didnt' you?");
					break;
				case GameStates.States.Loading:
					print("Loading...");
					break;
				case GameStates.States.Dying:
					print("You are dead. Donezo. Fine. Screwed. Capped.");
					break;
				
				case GameStates.States.Team1Score:
					break;
				case GameStates.States.Team2Score:
					break;
		}
	}
}
