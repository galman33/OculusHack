using UnityEngine;
using System.Collections;

public class StreetSceneChanger : MonoBehaviour {

	public float ChangeStartZ;

	AsyncOperation nextLvlOperation;

	// Use this for initialization
	void Start () {
		nextLvlOperation = Application.LoadLevelAsync(Application.loadedLevel + 1);
		nextLvlOperation.allowSceneActivation = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.z >= ChangeStartZ)
			nextLvlOperation.allowSceneActivation = true;
	}
}
