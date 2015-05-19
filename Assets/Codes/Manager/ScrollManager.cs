using UnityEngine;
using System.Collections;

public class ScrollManager : MonoBehaviour {

	private BackgroundManager[] _backgroundManagers;
	private Transform _landGround;
	private Vector3 _startpos;

	void Awake()
	{
		_backgroundManagers = FindObjectsOfType<BackgroundManager> ();
		_landGround = transform.GetChild (1);
		_startpos = _landGround.position;
	}

	public void StartMove()
	{
		iTween.MoveTo (_landGround.gameObject, iTween.Hash ("y", -7.43f, "easeType", iTween.EaseType.linear, "speed", 1));
		for(int i = 0; i < _backgroundManagers.Length; ++i)
		{
			_backgroundManagers[i].SendMessage("StartMove");
		}
	}
}
