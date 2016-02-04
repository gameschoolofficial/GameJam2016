using UnityEngine;
using System.Collections;

public class spawnCuties : MonoBehaviour {

	public Rigidbody cutieObject;
	public Transform spawnPoint;
	public float timer; 
	public float spawnDelay = 1f;
	
	private Rigidbody cutieInstance ; 
	private int cutieCount = 0;
	private int totalCuties = 0;

	// Use this for initialization
	void Start () {
	
		timer = 0f;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void createCutie(int numCuties,float timeDelay){
	
		//print ("creating cuties!");
		//for (int i = 0; i<= numCuties; i++) {
		totalCuties = numCuties;
		//print ("invoking " + numCuties + " with " + timeDelay + " delay");
		InvokeRepeating ("spawnInstance", timeDelay, 3f);
			
		//}
	}

	void spawnInstance(){
	
		cutieInstance = Instantiate (cutieObject, spawnPoint.position, spawnPoint.rotation) as Rigidbody;
		cutieInstance.AddForce(spawnPoint.right * 100);
		cutieCount++;
		//print("invoking cutieCount = "+ cutieCount);
		if(cutieCount >= totalCuties){
			//print ("canceling Invoke & cutieCount = " +cutieCount);
			CancelInvoke();
			cutieCount = 0;
		}
	}

}
