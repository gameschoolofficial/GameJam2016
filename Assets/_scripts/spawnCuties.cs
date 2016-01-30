using UnityEngine;
using System.Collections;

public class spawnCuties : MonoBehaviour {

	public Rigidbody cutieObject;
	public Transform spawnPoint;

	public float timer; 
	public float spawnDelay = 1f;

	// Use this for initialization
	void Start () {
	
		timer = 0f;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void createCutie(){
	
		print ("creating cuties!");
		Rigidbody cutieInstance ; 
		cutieInstance = Instantiate (cutieObject,spawnPoint.position, spawnPoint.rotation) as Rigidbody;
		
		cutieInstance.AddForce(spawnPoint.right * 500);
	}
}
