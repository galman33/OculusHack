using UnityEngine;
using System.Collections;

public class Fishy : MonoBehaviour {

    public GameObject Fish;
    public float Radius;
    public float Amount;
	// Use this for initialization
	void Start () {
        GameObject Temp;
        for (int i = 0; i < Amount; i++) {
			Temp = Instantiate (Fish, Random.insideUnitSphere * Radius, Quaternion.identity)as GameObject;
			Temp.transform.parent=this.transform;
		}
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate ((Vector3.forward+new Vector3(Random.Range(-10,10),0,0)) * Time.deltaTime);
	}
}
