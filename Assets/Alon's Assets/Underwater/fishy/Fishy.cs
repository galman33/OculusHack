using UnityEngine;
using System.Collections;

public class Fishy : MonoBehaviour {

    public GameObject FishObject;
	public GameObject AngelFishObject;
    public float Radius;
    public float Amount;
	public float FishyRadius;
	public float FishyAmount;
	// Use this for initialization
	void Start () {
		GameObject Fish = new GameObject();
		Fish.name = "Fishs";
		for(int i=0;i<FishyAmount;i++){
			
		
			GameObject Temp=new GameObject();
			Temp.transform.parent = Fish.transform;
			Temp.name="Fishy";
			Temp.transform.position=Random.insideUnitSphere * FishyRadius;
			Temp.AddComponent<MoveFishy>();
			Instantiate(AngelFishObject, Random.insideUnitSphere * Radius + Temp.transform.position, Quaternion.identity);
			GameObject Fishy;
			for (int j = 0; j < Amount; j++)
			{
				Fishy = Instantiate(FishObject, Random.insideUnitSphere * Radius + Temp.transform.position, Quaternion.identity) as GameObject;
				Fishy.transform.parent = Temp.transform;
			}
		}
	}
}
