using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	public static int amount = 0;
	public static GameObject[] humans =new GameObject[8];
	public GameObject humanagent;

	// Use this for initialization
	void Start () {
		//transform.Rotate(0,90,0);
		InvokeRepeating ("SpawnHuman", 3f, 1.3f);
	}
	
	//Spawns a new human
	void SpawnHuman()
	{
		if (amount < 8) {
			
			//side = which border: 0 = top, 1 = right, 2 = bottom, 3 = left
			int side = Random.Range (0, 3);
			int pos = Random.Range (-40, 40);
			int rotation = Random.Range (20, 160);
			switch (side) {
			case 0:
				humans [amount] = Instantiate (humanagent, new Vector3 (pos, 0, 45), Quaternion.AngleAxis (rotation + 90, Vector3.up)) as GameObject;	
				amount++;
				break;
			case 1:
				humans [amount] = Instantiate (humanagent, new Vector3 (45, 0, pos), Quaternion.AngleAxis (rotation + 180, Vector3.up)) as GameObject;	
				amount++;
				break;
			case 2:
				humans [amount] = Instantiate (humanagent, new Vector3 (pos, 0, -45), Quaternion.AngleAxis (rotation + 270, Vector3.up)) as GameObject;	
				amount++;
				break;
			case 3:
				humans [amount] = Instantiate (humanagent, new Vector3 (-45, 0, pos), Quaternion.AngleAxis (rotation + 0, Vector3.up)) as GameObject;	
				amount++;
				break;
			default:
				break;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
