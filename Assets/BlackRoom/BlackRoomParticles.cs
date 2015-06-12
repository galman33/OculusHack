using UnityEngine;
using System.Collections;

public class BlackRoomParticles : MonoBehaviour {


	private float BaseX; private float BaseZ;


	public float Mult;

	// Use this for initialization
	void Start () {
		BaseX = Perlin.GetRandomBase(); BaseZ = Perlin.GetRandomBase();
	}
	
	// Update is called once per frame
	void Update () {
		var pos = transform.position;
		pos.x = Perlin.GetSmoothRandom(-10, 10, Mult, BaseX);
		pos.z = Perlin.GetSmoothRandom(-10, 10, Mult, BaseZ);
		transform.position = pos;
	}
}
