using UnityEngine;
using System.Collections;

public class StreetPlayer : MonoBehaviour {

	public float fallingSpeed;

	public float RunAccel;

	// Use this for initialization
	void Start () {
		StartCoroutine(Internal());
	}

	private IEnumerator Internal()
	{
		yield return StartCoroutine(FallDown());
		yield return new WaitForSeconds(3.0f);
		yield return StartCoroutine(Run());
	}

	private IEnumerator FallDown()
	{
		float t = 0;
		while(t < 1)
		{
			t += Time.deltaTime * fallingSpeed;
			float y = Mathf.Lerp(30, 2, t);
			transform.position = new Vector3(0, y, 0);
			yield return null;
		}
		transform.position = new Vector3(0, 2, 0);
	}
	
	private IEnumerator Run()
	{
		float z = 0;
		float vel = 0;

		while (true)
		{
			z += vel * Time.deltaTime + 0.5f * RunAccel * Time.deltaTime * Time.deltaTime;
			vel += RunAccel * Time.deltaTime;
			transform.position = new Vector3(0, 2, z);
			yield return null;
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
