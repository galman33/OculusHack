using UnityEngine;
using System.Collections;

public class BlackRoomObject : MonoBehaviour {

	public float ScaleMult;
	public float ScaleMin;
	public float ScaleMax;


	private float baseScaleX; private float baseScaleY; private float baseScaleZ;
	private float baseColorR; private float baseColorG; private float baseColorB; private float baseColorA;

	private float baseRotX; private float baseRotY; private float baseRotZ;
	private float baseAngle;

	public float MaxPositionRadius;
	public float MinPositionRadius;

	public float MaxLifeTime;
	public float MinLifeTime;

	public float RotMult;

	private Material material;


	public bool Target = false;

	// Use this for initialization
	void Start () {
		this.material = GetComponent<Renderer>().material;
		baseScaleX = Perlin.GetRandomBase(); baseScaleY = Perlin.GetRandomBase(); baseScaleZ = Perlin.GetRandomBase();
		baseColorR = Perlin.GetRandomBase(); baseColorG = Perlin.GetRandomBase(); baseColorB = Perlin.GetRandomBase(); baseColorA = Perlin.GetRandomBase();

		baseRotX = Perlin.GetRandomBase(); baseRotY = Perlin.GetRandomBase(); baseRotZ = Perlin.GetRandomBase();
		baseAngle = Perlin.GetRandomBase();

		if (!Target)
		{
			var radius = Random.Range(MinPositionRadius, MaxPositionRadius);
			transform.position = Random.onUnitSphere * Random.value * radius;


			Destroy(gameObject, Random.Range(MinLifeTime, MaxLifeTime));
		}
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 scale = Vector3.zero;
		scale.x = Perlin.GetSmoothRandom(ScaleMin, ScaleMax, ScaleMult, baseScaleX);
		scale.y = Perlin.GetSmoothRandom(ScaleMin, ScaleMax, ScaleMult, baseScaleY);
		scale.z = Perlin.GetSmoothRandom(ScaleMin, ScaleMax, ScaleMult, baseScaleZ);
		transform.localScale = scale;


		Color color = new Color();
		color.r = Perlin.GetSmoothRandom(0, 1, 0.5f, baseColorR);
		color.g = Perlin.GetSmoothRandom(0, 1, 0.5f, baseColorG);
		color.b = Perlin.GetSmoothRandom(0, 1, 0.5f, baseColorB);
		color.a = Perlin.GetSmoothRandom(0.5f, 1, 0.2f, baseColorA);
		this.material.color = color;

		var pos = transform.position;
		Vector3 rot = new Vector3();
		rot.x = Perlin.GetSmoothRandom(0, 1, 0.5f, baseRotX);
		rot.y = Perlin.GetSmoothRandom(0, 1, 0.5f, baseRotY);
		rot.z = Perlin.GetSmoothRandom(0, 1, 0.5f, baseRotZ);
		var angle = Perlin.GetSmoothRandom(-360, 360, 0.5f, baseAngle) * RotMult * Time.deltaTime;
		pos = Quaternion.AngleAxis(angle, rot) * pos;
		transform.position = pos;
	}
}
