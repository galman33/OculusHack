using UnityEngine;
using System.Collections;

public class BlackRoomObjectSpawner : MonoBehaviour {

	public GameObject ToSpawn;

	public float MinSpawnTime;
	public float MaxSpawnTime;

	// Use this for initialization
	void Start () {
		StartCoroutine(SpawnThemAll());
	}

	private IEnumerator SpawnThemAll()
	{
		while(true)
		{
			yield return new WaitForSeconds(Random.Range(MinSpawnTime, MaxSpawnTime));
			var lel = Instantiate(ToSpawn);
			lel.transform.parent = transform;
		}
	}
	
}
