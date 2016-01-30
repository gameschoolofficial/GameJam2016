using UnityEngine;
using System.Collections;

public class spawnTarget : MonoBehaviour {

	//public float turnSpeed = 10f;
	public float timer = 0f;
	public float spawnDuration = 4f;
	public GameObject targetBoardObjects;
	public Transform targetSpawnPoint;
	
	private GameObject targetInstance;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	public void Update () {

	}

	public void targetOn(){

		//instantiate a prefab target
		targetInstance = Instantiate (targetBoardObjects,targetSpawnPoint.position, targetSpawnPoint.rotation) as GameObject;
		//choose the type of points to give the prefab

	}

	public void targetOff(){
		Destroy (targetInstance);
	}
	

}
