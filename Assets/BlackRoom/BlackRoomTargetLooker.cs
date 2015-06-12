using UnityEngine;
using System.Collections;

public class BlackRoomTargetLooker : MonoBehaviour {

	public Transform Target;

	public float LookingVec;

	public float FillRate;

	private float fillment;

	// Use this for initialization
	void Start () {
		fillment = 0;
	}
	
	// Update is called once per frame
	void Update () {
		var neededVec = Target.position - transform.position;
		var forawrdVec = transform.forward;
		if(Vector3.Angle(neededVec, forawrdVec) < LookingVec)
		{
			fillment += FillRate * Time.deltaTime;
		}
		else
		{
			fillment -= FillRate * Time.deltaTime;
		}
		fillment = Mathf.Clamp01(fillment);

		GetComponent<Camera>().backgroundColor = new Color(fillment, fillment, fillment, 1);
	}
}
