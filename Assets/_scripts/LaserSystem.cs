using UnityEngine;
using System.Collections;

public class LaserSystem : MonoBehaviour {
	public float chargeTime;
	public float fireTime;
	public GameObject laserCylinder;

	private enum LaserState {none, idle, firing}
	private LaserState myState;

	// Use this for initialization
	void Start () 
	{

		StartCoroutine(enterState(LaserState.idle));
	}

	private void turnOnLaser()
	{
		laserCylinder.SetActive(true);
	}

	private void turnOffLaser()
	{
		laserCylinder.SetActive(false);
	}

	IEnumerator enterState(LaserState newState)
	{
		switch (newState) {
		case LaserState.idle:
			//turnOff laser
			turnOffLaser();
			print("laser off");
			yield return new WaitForSeconds(chargeTime);
			break;
		case LaserState.firing:
			turnOnLaser();
			print("laser on");
			yield return new WaitForSeconds(fireTime);
			break;
		case LaserState.none:
			break;
		default:
			break;
		}
		StartCoroutine( leaveState (newState));
	}

	IEnumerator leaveState(LaserState oldState)
	{

		LaserState newState = LaserState.none;

		switch (oldState) {
		case LaserState.idle:
			//enterState(LaserState.firing);
			newState = LaserState.firing;
			break;
		case LaserState.firing:
			//enterState(LaserState.idle);
			newState = LaserState.idle;
			break;
		case LaserState.none:
			break;
		default:
			break;
		}
		print("cats " + newState);
		StartCoroutine( enterState(newState));
		yield return null;
	}




}
