using UnityEngine;
using System.Collections;

public class spawnTarget : MonoBehaviour {

	public float turnSpeed = 10f;
	public float timer = 0f;
	public float spawnDuration = 5f;

	// when OFF, only spawning target is available
	// when ON, activate timer before activating off state
	private enum targetState{ STATE_OFF, STATE_ON, STATE_TRANSITION };
	targetState myState = targetState.STATE_OFF;

	// Use this for initialization
	void Start () {
	
		transform.Rotate (new Vector3(0,0,270) ); //if target if off
	}
	
	// Update is called once per frame
	void Update () {

		if(myState == targetState.STATE_OFF){
			targetOn ();
		}
		//continue timer, but do nothing
		if (myState == targetState.STATE_ON && timer <= spawnDuration) {
			timer += Time.deltaTime;
		} 
		//when timer has run out, turn target off
		if (myState == targetState.STATE_ON && timer >= spawnDuration) {
			targetOff();
		}

	}

	void targetOn(){

		if (transform.rotation.eulerAngles.z >= 268.0 && transform.rotation.eulerAngles.z <= 358.0) {
			transform.Rotate (Vector3.forward, turnSpeed * Time.deltaTime);
		} else {
			//set rotation back to 360
			transform.Rotate (new Vector3(0,0,359) );
			myState = targetState.STATE_ON;
		}
	}

	void targetOff(){

		if (transform.rotation.eulerAngles.z >= 270.0 && transform.rotation.eulerAngles.z <= 360.0) {
			transform.Rotate (Vector3.back, turnSpeed * Time.deltaTime);
		} else {
			myState = targetState.STATE_OFF;
			timer = 0f;
		}

	}


}
