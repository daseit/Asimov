using UnityEngine;
using System.Collections;

public class Robot : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "SpartanKing" || col.gameObject.name == "SpartanKing2" || col.gameObject.name == "SpartanKing3")
		{
			Interface.saved=Interface.saved+1;
			//Destroy(col.gameObject);
			col.gameObject.transform.position =new Vector3(Random.Range(-29, 33), 0, Random.Range(-36, 21));
		}
	}
}
