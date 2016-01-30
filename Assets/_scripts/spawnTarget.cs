using UnityEngine;
using System.Collections;

public class spawnTarget : MonoBehaviour {

	//public float turnSpeed = 10f;
	public float timer = 0f;
	public float spawnDuration = 4f;
	public GameObject targetBoardObjects;
	public Transform targetSpawnPoint;



	// when OFF, only spawning target is available
	// when ON, activate timer before activating off state
	//private enum targetState{ STATE_OFF, STATE_ON, STATE_TRANSITION };
	//targetState myState = targetState.STATE_OFF;

	private GameObject targetInstance;

	// Use this for initialization
	void Start () {
		//resetTargetObject ();
	}
	
	// Update is called once per frame
	public void Update () {

	}

	public void targetOn(){

		print ("activating Target ON");
		//instantiate a prefab target
		targetInstance = Instantiate (targetBoardObjects,targetSpawnPoint.position, targetSpawnPoint.rotation) as GameObject;
		print ("Position="+targetSpawnPoint.position);
		//choose the type of points to give the prefab

	}

	public void targetOff(){
		Destroy (targetInstance);
	}

	void resetTargetObject(){

		//destroy all instances created?
	}

}
