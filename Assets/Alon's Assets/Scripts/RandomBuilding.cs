using UnityEngine;
using System.Collections;

public class RandomBuilding : MonoBehaviour {

	public Material[] materials;
	public float minScale, maxScale;
	private float random;

	// Use this for initialization
	void Start () {
		random = Random.Range (minScale, maxScale);
		transform.localScale = new Vector3 (random / 2, random, random / 2);
		transform.localEulerAngles = new Vector3 (0f, Random.Range (-180f, 180f), Random.Range(-7.5f, 7.5f));
		transform.localPosition = new Vector3 (transform.localPosition.x, random / 2, transform.localPosition.z);
		if(materials.Length > 0)
			GetComponent<Renderer> ().material = materials [(Random.Range (0, materials.Length))];
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
