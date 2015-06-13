using UnityEngine;
using System.Collections;

public class MoveToObject : MonoBehaviour {

    public GameObject CreatedObject;
    public float Radius;
    private string ObjectLookAt;
	private Vector3 ObjectLookAtVector;
	private bool Walking=false;
    private int timer=0;
    private RaycastHit hit;
	// Use this for initialization
	void Start () {
		for(int i=0;i<5;i++)
			Instantiate(CreatedObject, GivePosition(), Quaternion.identity).name=(CreatedObject.name+i.ToString());
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 fwd = transform.TransformDirection(Vector3.forward);
		Debug.DrawRay(transform.position, transform.TransformDirection (Vector3.forward*100), Color.green);
		if (Physics.Raycast(transform.position, fwd, out hit))
			if (!Walking&&hit.transform.tag=="Flag") {
				if(hit.transform.name==ObjectLookAt)
				timer++;
			else
			{
				Debug.Log(hit.transform.name);
				timer=0;
				ObjectLookAt=hit.transform.name;
				ObjectLookAtVector=hit.transform.position-transform.position;
			}

		}
		

		if (timer > 50 && Vector3.Distance (hit.point, transform.position) > 1f) {
			transform.Translate ((hit.point-transform.position) * Time.deltaTime,   Space.World);
			Walking=true;
		}else if(timer>50){
			timer=0;
			Walking=false;
		}
	}
    public Vector3 GivePosition()
    {
        Vector3 temp = Random.onUnitSphere * Radius;
        temp = new Vector3(temp.x, Mathf.Abs(temp.y), temp.z);
        return transform.position + temp;
    }
}
