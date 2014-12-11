using UnityEngine;
using System.Collections;

public class Danger_Zone : MonoBehaviour {

	public static float distance;

	public Transform Human;

	public static GameObject zone;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//distance1 = Mathf.Abs(Vector3.Distance (this.transform.position, spartan1.position));
	}

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Human(Clone)" )
		{
			Interface.dead=Interface.dead+1;
			Interface.total +=1;
			Destroy(col.gameObject);
			col.gameObject.transform.position =new Vector3(Random.Range(-29, 33), 0, Random.Range(-36, 21));
			Spawn.amount--;

		}
	}
}
