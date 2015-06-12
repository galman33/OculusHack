using UnityEngine;
using System.Collections;

public class BlackRoomLight : MonoBehaviour {

	private Light light;

	public float intensityBase;
	public float intensityMult;

	public float colorChangeMult;

	// Use this for initialization
	void Start () {
		this.light = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
		this.light.intensity = Perlin.GetSmoothRandom(-1, 9, intensityMult, intensityBase);

		Color color = new Color();
		color.r = Perlin.GetSmoothRandom(0, 1, 0.5f, 100);
		color.g = Perlin.GetSmoothRandom(0, 1, 0.5f, 200);
		color.b = Perlin.GetSmoothRandom(0, 1, 0.5f, 300);
		this.light.color = color;
	}

}
