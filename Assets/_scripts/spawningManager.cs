using UnityEngine;
using System.Collections;

public class spawningManager : MonoBehaviour {


	private float timer = 0f;
	private int levelReached = 1;
	private bool levelComplete = false;
	public float spawnDelay = 2f;

	public int score = 0;

	//get objects for the ranges of the targets
	public Transform rangeOfSpawn1;
	public Transform rangeOfSpawn2;

	//get all targets used in game
	public spawnTarget spawnTargetPoint;
	public spawnTarget spawnTargetPoint1;
	public spawnTarget spawnTargetPoint2;
	public spawnTarget spawnTargetPoint3;
	public spawnTarget spawnTargetPoint4;
	public spawnTarget spawnTargetPoint5;
	public spawnTarget spawnTargetPoint6;
	public spawnTarget spawnTargetPoint7;
	public spawnTarget spawnTargetPoint8;
	public spawnTarget spawnTargetPoint9;



//	//private spawnTarget[] allTargetPoints = new spawnTarget[]{
//		spawnTargetPoint,
//		spawnTargetPoint1,
//		spawnTargetPoint2,
//		spawnTargetPoint3,
//		spawnTargetPoint4,
//		spawnTargetPoint5,
//		spawnTargetPoint6,
//		spawnTargetPoint7,
//		spawnTargetPoint8,
//		spawnTargetPoint9
//	};
	
	public spawnCuties spawnCutiePoint; 
	public spawnCuties spawnCutiePoint1; 
	public spawnCuties spawnCutiePoint2; 
	public spawnCuties spawnCutiePoint3; 
	public spawnCuties spawnCutiePoint4;

	/*
	private spawnCuties[] allCutieSpawnPoints = new spawnCuties[] {
		spawnCutiePoint,
		spawnCutiePoint1,
		spawnCutiePoint2,
		spawnCutiePoint3,
		spawnCutiePoint4
	};
*/

	// Use this for initialization
	void Start () {
		timer = 0;
		activateLevel (1);
	}

	// Update is called once per frame
	void Update () {
	

		//designing level 1
		//need to randomly spawn targets around the scene. 

		/*
		activateLevel (levelReached);


		if (levelComplete) {
			levelReached++;
		}
		*/

	}

	public void activateLevel(int level){


		//use transform.rotation y moves clockwise (+) or counter (-)

		switch (level) {
		case 1 :
			//print ("Entering Level "+level);

			//Add voice over: 
			// Welcome to the laser simulator.  To calibrate the laser, please look at the targets as they appear. 
			// 

			spawnTargetPoint.targetOn(5f);
			spawnTargetPoint1.targetOn(7f);
			spawnTargetPoint2.targetOn(9f);

			//spawnTargetPoint3.targetOn();
			//spawnTargetPoint4.targetOn();
			//spawnTargetPoint5.targetOn();

			//VO: "Good, now that we've calibrated the laser, let's see how fast you can take these targets down"

			//add delay()
			spawnCutiePoint.createCutie(5,10f);

			//VO: "Oh how cute, a creature has just been released from our lab"

			//VO: "Oh no! you've shot a creature, beware their family is coming for you!"


			spawnCutiePoint1.createCutie(3,15f);

			//check to see that all of the targets have been taken out. 

			//activate 
			break;
		case 2 :
			print ("Entering Level "+level);



			break;

		case 3 :
			print ("Entering Level "+level);
			break;

		default: 
			print ("default activating");
			break;
		}

	}


}
