using UnityEngine;
using System.Collections;

public class spawningManager : MonoBehaviour {


	private float timer = 0f;
	public float spawnDelay = 2f;

	public GameObject targetBoard0;
	public GameObject targetBoard1;
	public GameObject targetBoard2;

	public int numOfObjects = 10;


	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
		//need to randomly spawn targets around the scene. 
		//set random timer, and activate 


		timer += Time.deltaTime;

		if (timer < spawnDelay) {

			//spawnTarget
			print ("spawn a target");
		}
	}


	void spawnTargetBoard(){

		//Instantiate (targetBoard, new Vector3 ());
	}
	







}
