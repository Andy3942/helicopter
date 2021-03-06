// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using UnityEngine;
namespace Application
{
	public class GameStartState:IGameState
	{
		private readonly GameManager _manager;
		public IGameState _CurrentState;
		public Transform _btnGroup;
		public Transform _board;
		public Transform _Obstacles_Group;
		private int layerInt;
		public GameStartState (GameManager manager)
		{
			this._manager = manager;
			this._CurrentState = manager._CurrentState;
			this._btnGroup = manager._btnGroup;
			this._board = manager._board;
			this._Obstacles_Group = manager._Obstacles_Group;

			_btnGroup.gameObject.SetActive (true);
			_Obstacles_Group.gameObject.SetActive (true);
			_board.gameObject.SetActive (true);

			layerInt = LayerMask.NameToLayer ("UI");
		}

		public override void Update()
		{
			if (Input.GetMouseButtonDown (0)) 
			{
				Vector3 mouseVector3 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				RaycastHit2D hit;
				hit = Physics2D.Raycast(Camera.main.transform.position, mouseVector3, 100, 1 << layerInt);
				if(hit.collider != null)
				{
					switch(hit.collider.name)
					{
					case "btnStart":
						SwitchNext();
						break;
					case "btnRank":
						Debug.Log("R");
						break;
					}
				}
			}
		}

		public override void SwitchNext()
		{
			_btnGroup.gameObject.SetActive (false);
			_Obstacles_Group.gameObject.SetActive (false);
			_board.gameObject.SetActive (false);
			_manager._CurrentState = new GameRunState (_manager);
		}
	}
}

