using UnityEngine;
using System.Collections;

public class FloatSelf : MonoBehaviour {

	// Use this for initialization
	void Start () {
		iTween.MoveBy (gameObject, iTween.Hash ("y", 0.5f, "time", 1, "loopType", iTween.LoopType.pingPong, "easeType", iTween.EaseType.linear));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
