using UnityEngine;
using System.Collections;

public class spawningManager : MonoBehaviour {


	//private float timer = 0f;
	private int levelReached = 1;
	private bool levelComplete = false;

	private int targetHitCount = 0;
	private int kittyHitCount = 0;


	public float spawnDelay = 2f;
	public AudioSource intro;
	public AudioSource part2;

	//public int score = 0;

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
		//timer = 0;
		activateLevel (1);
	}

	// Update is called once per frame
	void Update () {

		//activate different levels as you finish each level task
		//levelreached;

		//activateLevel (levelReached);


	}

	public void activateLevel(int level){


		//use transform.rotation y moves clockwise (+) or counter (-)


		switch (level) {
		case 1 :
			//print ("Entering Level "+level);

			//Add voice over: 
			// Hello there!  I'm Dr. Summers and I will be calibrating your new cybernetic eye implants.  
			// Now let's see how the lasers in your eyes work!  Yes, i said LASERS!       
			// I'll put some targets for you to shoot down, just simply look at them and once the target is locked on
			// the laser will activate.  

			//VO is 17seconds.

			//intro.Play ();
			spawnTargetPoint.targetOn(2f);//18f
			spawnTargetPoint1.targetOn(3f);//19f
			spawnTargetPoint2.targetOn(4f);//20f

			//while(targetHitCount < 3){
			
				// do nothing
				//print ("***"+targetHitCount);

			//}

			//levelReached++;
			//levelComplete = true;
			print ("Now run this");

			//activate 
			break;
		case 2 :
			print ("Entering Level "+level);

			//VO: 
			//Great Job! now let's test your reflexes and see how fast you can shoot them down!

			//part2.Play ();
			spawnTargetPoint.targetOn(26f);
			spawnTargetPoint1.targetOn(27f);
			spawnTargetPoint2.targetOn(27f);
			
			spawnTargetPoint3.targetOn(28f);
			spawnTargetPoint4.targetOn(28f);
			spawnTargetPoint5.targetOn(28f);

			break;

		case 3 :
			//print ("Entering Level "+level);
			//VO: "Incredible! Now that you know how they work, let's throw some more 
			
			//add delay()
			spawnCutiePoint.createCutie(2,30f);
			
			//VO: "Oh how cute, a creature has just been released from our lab"
			
			//VO: "Oh no! you've shot a creature, beware their family is coming for you!"
			
			
			spawnCutiePoint1.createCutie(3,15f);
			
			//check to see that all of the targets have been taken out. 
			break;

		default: 
			print ("default activating");
			break;
		}

	}

	public void countTargetHit(){

		targetHitCount++;
	}

	public void countKittyHit(){
		
		kittyHitCount++;
	}


}
