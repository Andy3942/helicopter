using UnityEngine;
using System.Collections;

public class BackgroundManager : MonoBehaviour {
	public float _OffsetY = 15;

	void StartMove()
	{
		Invoke ("MoveDown", 0);
	}

	void MoveDown()
	{
		iTween.MoveTo (gameObject, iTween.Hash ("y", -10, "easeType", iTween.EaseType.linear, "speed", 1, "onComplete", "ResetPosition"));
	}

	void ResetPosition()
	{
		transform.localPosition = new Vector3 (transform.position.x, transform.position.y + _OffsetY);
		Invoke ("MoveDown", 0);
	}
}
