using UnityEngine;
using System.Collections;

public class MoveFishy : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		transform.Translate ((Vector3.forward+new Vector3(Random.Range(-2,2),0,0)) * Time.deltaTime);
	}
}
