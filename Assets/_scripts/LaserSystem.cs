using UnityEngine;
using System.Collections;

public class LaserSystem : MonoBehaviour {
	public float chargeTime;
	public float fireTime;
	public GameObject laserPointer;
	public LineRenderer laserLine;


	public static LaserSystem mainLaser;

	public enum LaserState {none, idle, firing}
	public LaserState myState;
	float laserAlpha = 1;
	public float LaserDissapearSpeed;


	/*
	public ParticleSystem endEffect;
	public Transform endEffectTransform;
	Transform myTransform;
	public int maxLength;
	int length;
	Vector3[] position;*/

	void Awake()
	{
		mainLaser = this;

	}

	// Use this for initialization
	void Start () 
	{
//		myTransform = transform; //is it? 
		//laserAlpha = 1;
		laserLine.SetVertexCount(2);
		StartCoroutine(enterState(LaserState.idle));
	}



	void Update()
	{
		//UpdateLength();
		if( laserAlpha > 0.1f)
		{laserAlpha -= Time.deltaTime * LaserDissapearSpeed;}
		Color c = Color.red; 
		c.a = laserAlpha;
		laserLine.material.color = c;

	}

	private void turnOnLaser()
	{

		laserLine.SendMessage("laserEnabled", true);
		laserLine.SetPosition(0, laserPointer.transform.position);
		laserLine.SetPosition(1, Camera.main.transform.forward * 100);

		laserAlpha = 0.6f;
	}

	private void turnOffLaser()
	{
		laserLine.SendMessage("laserEnabled", true);
	}

	IEnumerator enterState(LaserState newState)
	{
		switch (newState) {
		case LaserState.idle:
			//turnOff laser
			turnOffLaser();

			yield return new WaitForSeconds(chargeTime);
			break;
		case LaserState.firing:
			turnOnLaser();

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

		StartCoroutine( enterState(newState));
		yield return null;
	}


	/*
	void UpdateLength(){
		//Raycast from the location of the cube forwards
		RaycastHit[] hit;
		hit = Physics.RaycastAll(myTransform.position, myTransform.forward, maxLength);
		int i = 0;
		while(i < hit.Length){
			print("hit");
			//Check to make sure we aren't hitting triggers but colliders
			if(!hit[i].collider.isTrigger)
			{
				length = (int)Mathf.Round(hit[i].distance)+2;
				position = new Vector3[length];
				//Move our End Effect particle system to the hit point and start playing it
				if(endEffect){
					endEffectTransform.position = hit[i].point;
					if(!endEffect.isPlaying)
						endEffect.Play();
				}
				laserLine.SetVertexCount(length);
				return;
			}
			i++;
		}
		//If we're not hitting anything, don't play the particle effects
//		if(endEffect){
//			if(endEffect.isPlaying)
//				endEffect.Stop();
//		}
		length = (int)maxLength;
		position = new Vector3[length];
		//laserLine.SetVertexCount(length);
		
		
	}*/




}
