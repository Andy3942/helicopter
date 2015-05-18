using UnityEngine;
using System.Collections;
using Application;

public class GameManager : MonoBehaviour {

	public IGameState _CurrentState;

	// Use this for initialization
	void Start () {
		_CurrentState = new GameStartState (this);
	}
	
	// Update is called once per frame
	void Update () {
		_CurrentState.Update ();
	}
}
