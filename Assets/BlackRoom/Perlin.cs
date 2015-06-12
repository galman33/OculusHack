using UnityEngine;
using System.Collections;

public static class Perlin
{

	public static float GetRandomBase()
	{
		return Random.value * 99999f;
	}

	public static float GetSmoothRandom(float min = 0.0f, float max = 1.0f,
	float multX = 0f, float baseX = 0f,
	float multY = 0f, float baseY = 0f)
	{
		float x = baseX + multX * Time.time;
		float y = baseY + multY * Time.time;

		float num = Mathf.PerlinNoise(x, y);

		float output = num * (max - min) + min;

		return output;
	}
	
}
