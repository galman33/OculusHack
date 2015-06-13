using UnityEngine;
using System.Collections;

public class UnderWatreMovement : MonoBehaviour {

	public float MoveSpeed;
	public Transform MoveAccordingTo;

	private bool move;

	// Use this for initialization
	void Start () {
		move = false;
		StartCoroutine(WaitTillStart());
	}

	private IEnumerator WaitTillStart()
	{
		yield return new WaitForSeconds(4.0f);
		move = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(move)
		{
			var moveVec = MoveAccordingTo.forward;
			//moveVec.y = 0;
			moveVec.Normalize();
			transform.Translate(moveVec * Time.deltaTime * MoveSpeed, Space.World);
		}
		
	}
}
