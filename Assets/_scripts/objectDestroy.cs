using UnityEngine;
using System.Collections;

public class objectDestroy : MonoBehaviour {

	//public GameObject spawnMgr;
	//private spawningManager mgrInstance;
	//public scoreManager scoreMgr; 
	public GameObject scoreObj;
	private scoreManager scoreInst;

	public void destroyObject(){
	
		//print ("destroy - gameObject type = "+gameObject.name);

		//mgrInstance = spawnMgr.GetComponent<spawningManager> () as spawningManager;
		//print (mgrInstance);
		scoreInst = scoreObj.GetComponent<scoreManager> () as scoreManager;
		if (gameObject.name == "targetBoardSmall(Clone)") {
		
			scoreInst.addToScore(1);
			//mgrInstance.countTargetHit();
			//spawnMgr.countTargetHit();
			print ("destroying smalltarget");
		};
		if (gameObject.name == "kitty(Clone)") {

			//scoreInst.addToScore(2);
			//mgrInstance.countKittyHit();
			//spawnMgr.countTargetHit();
			print ("destroying kitty!");
		};


		Destroy (gameObject);
	}


}