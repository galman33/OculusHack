using UnityEngine;
using System.Collections;

public class Fishy : MonoBehaviour {

    public GameObject Fish;
    public float Radius;
    public float Amount;
	public float FishyRadius;
	public float FishyAmount;
	// Use this for initialization
	void Start () {
		for(int i=0;i<FishyAmount;i++){
        GameObject Temp=new GameObject();
			Temp.name="Fishy";
			Temp.transform.position=Random.insideUnitSphere * FishyRadius;
			Temp.AddComponent<MoveFishy>();
			GameObject Fishy;
        for (int j = 0; j < Amount; j++) {
				Fishy = Instantiate (Fish, Random.insideUnitSphere * Radius+Temp.transform.position, Quaternion.identity)as GameObject;
				Fishy.transform.parent=Temp.transform;
		}
		}
	}
}
