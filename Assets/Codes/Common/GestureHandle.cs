using UnityEngine;
using System.Collections;
using Application;

public class GestureHandle : MonoBehaviour {
	
	void OnMouseDown()
	{
		Debug.Log("kkkkkkkk");
		gameObject.SetActive (false);
		GameRunState.Instance.PrepareGameStart ();
	}

	void Start()
	{
		Debug.Log ("123456");
	}

	void Update()
	{

	}
}
