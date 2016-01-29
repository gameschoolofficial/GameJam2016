using UnityEngine;
using System.Collections;

public class spawnCuties : MonoBehaviour {

	public Rigidbody cutieObject;
	public Transform spawnPoint;

	public float timer; 

	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {

		//set a randomized timer to spawn these cuties
	

		if(Input.GetKeyUp(KeyCode.Space)){

			Rigidbody cutieInstance ; 
			cutieInstance = Instantiate (cutieObject,spawnPoint.position, spawnPoint.rotation) as Rigidbody;

			cutieInstance.AddForce(spawnPoint.right * 500);
		}

	}
}
