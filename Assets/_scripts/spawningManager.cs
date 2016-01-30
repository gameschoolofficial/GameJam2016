using UnityEngine;
using System.Collections;

public class spawningManager : MonoBehaviour {


	private float timer = 0f;
	private int levelReached = 1;
	private bool levelComplete = false;
	public float spawnDelay = 2f;

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

		switch (level) {
		case 1 :
			//print ("Entering Level "+level);
			//spawnTestPoint.targetOn();
			spawnTargetPoint.targetOn();
			spawnTargetPoint1.targetOn();
			spawnTargetPoint2.targetOn();

			//add delay()
			spawnCutiePoint.createCutie();
			spawnCutiePoint1.createCutie();


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
