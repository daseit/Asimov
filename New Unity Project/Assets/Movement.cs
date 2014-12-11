using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public Vector3 speed = new Vector3(0,0,1);
	private bool saved = false;
	public AIPath botscript;

	// Use this for initialization
	void Start () {
		//transform.Rotate(0,90,0);

	}



	
	// Update is called once per frame
	void Update ()
	{
	
		transform.Translate(speed * Time.deltaTime * 7);
	}
	void OnCollisionStay (Collision col)
	{
		if (AIPath.target != null) {
						if (col.gameObject.name == "Bot" && saved == false && this.transform == AIPath.target.transform) {
								//speed.x *= -1;
		
								this.gameObject.transform.Rotate (Vector3.up, 180);
								Interface.saved += 1;

								saved = true;
								AIPath.target = AIPath.spawnpoint.transform;

		

								botscript = col.gameObject.GetComponent ("AIPath") as AIPath;
								botscript.TrySearchPath ();
								//yield return new WaitForSeconds (0.1);
	
								//transform.Rotate(transform.eulerAngles.x,transform.eulerAngles.y-150,transform.eulerAngles.z);
						}
				}
		if(col.gameObject.name.StartsWith("border"))
		{
			Destroy(this.gameObject);
			Interface.total +=1;
			Spawn.amount--;
			//speed.x *= -1;
			//transform.Rotate(transform.eulerAngles.x,transform.eulerAngles.y-150,transform.eulerAngles.z);
		}
	}
}
