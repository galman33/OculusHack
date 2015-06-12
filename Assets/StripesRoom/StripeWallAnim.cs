using UnityEngine;
using System.Collections;

public class StripeWallAnim : MonoBehaviour {

	public float Speed;
	public float FadeSpeed;
	public float DelayTime;

	private Material material;

	public Texture FirstTexture;
	public Texture SecondTexture;
	public Texture ThirdTexture;

	// Use this for initialization
	void Start () {
		material = GetComponent<Renderer>().sharedMaterial;

		StartCoroutine(Internal());
	}

	private IEnumerator Internal()
	{
		material.SetColor("_EmissionColor", Color.white);
		material.mainTexture = FirstTexture;

		yield return StartCoroutine(FadeIn());

		yield return new WaitForSeconds(DelayTime);

		yield return StartCoroutine(FadeOut());
		material.mainTexture = SecondTexture;
		yield return StartCoroutine(FadeIn());

		yield return new WaitForSeconds(DelayTime);

		yield return StartCoroutine(FadeOut());
		material.mainTexture = ThirdTexture;
		yield return StartCoroutine(FadeIn());

		yield return new WaitForSeconds(DelayTime);

		yield return StartCoroutine(FadeOut());
	}

	private IEnumerator FadeIn()
	{
		float t = 1;
		while(t > 0)
		{
			t -= Time.deltaTime * FadeSpeed;
			material.SetColor("_EmissionColor", new Color(t, t, t));
			yield return null;
		}
		material.SetColor("_EmissionColor", Color.black);
	}

	private IEnumerator FadeOut()
	{
		float t = 0;
		while (t < 1)
		{
			t += Time.deltaTime * FadeSpeed;
			material.SetColor("_EmissionColor", new Color(t, t, t));
			yield return null;
		}
		material.SetColor("_EmissionColor", Color.white);
	}
	
	// Update is called once per frame
	void Update () {
		material.mainTextureOffset += Vector2.up * Speed * Time.deltaTime;
		
	}
}
