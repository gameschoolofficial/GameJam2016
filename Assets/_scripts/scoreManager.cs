using UnityEngine;
using System.Collections;

public class scoreManager : MonoBehaviour {

	public TextMesh gameScore;

	private int numTargetKilled;
	private int numCutiesKilled; 
	int gameIntScore;

	// Use this for initialization
	void Awake () {
	
		//overallScore = 0;
		//numTargetKilled = 0;
		//numCutiesKilled = 0;
		print ("initializing score to 0");
		print ("overallScore = " + gameIntScore);
		print ("numTargetKilled = " + numTargetKilled);
	}
	
	// Update is called once per frame
	void Update () {
	
		//gameScore.text = gameIntScore.ToString();
		//print ("update: " + gameIntScore);
	
	}

	public void addToScore(int objType){
	
		//1 - targets
		//2 - cats

		//Variables in here don't seem to match the local variables to this class. 

		print ("addToScore score: "+gameIntScore);
		print ("numTargetKilled: "+numTargetKilled);

		if (objType == 1) {
			numTargetKilled++;
			print (numTargetKilled + " Targets destroyed");

			//overallScore = overallScore + 100;
			gameIntScore += 100;
			print ("new Score "+ gameIntScore);
		}
		if (objType == 2) {

			numCutiesKilled++;
			//overallScore -= 1;
			print ("add Kitty score " + gameIntScore);
		}

	}


}
