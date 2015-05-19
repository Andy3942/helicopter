using UnityEngine;
using System.Collections;
using Application;

public class GameManager : MonoBehaviour {

	public IGameState _CurrentState;
	public Transform _btnGroup;
	public Transform _board;
	public Transform _Obstacles_Group;
	public Transform _gesture;
	// Use this for initialization
	void Start () {
		_board = GameObject.Find ("Board").transform;
		_btnGroup = GameObject.Find ("btn_Group").transform;
		_Obstacles_Group = GameObject.Find ("Obstacle_Group").transform;
		_gesture = GameObject.Find ("tutorial").transform;
		_CurrentState = new GameStartState (this);
	}
	
	// Update is called once per frame
	void Update () {
		_CurrentState.Update ();
	}
}
