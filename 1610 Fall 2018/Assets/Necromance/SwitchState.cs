using UnityEngine;
using UnityEngine.Events;

public class SwitchState : MonoBehaviour
{

	public GameStates.States GameState;

	public UnityEvent Following, NotFollowing;

	public void ChangeState(GameStates.States state)
	{
		GameState = state;
	}

	// Update is called once per frame
	void Update()
	{
		switch (GameState)
		{
			case GameStates.States.Following:

				break;
			case GameStates.States.NotFollowing:

				break;

		}
	}
}
