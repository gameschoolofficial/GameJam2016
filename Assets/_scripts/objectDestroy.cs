using UnityEngine;
using System.Collections;

public class objectDestroy : MonoBehaviour {

	//public GameObject spawnMgr;
	//private spawningManager mgrInstance;

	public void destroyObject(){
	
		//print ("destroy - gameObject type = "+gameObject.name);
		/*
		mgrInstance = spawnMgr.GetComponent<spawningManager> () as spawningManager;
		print (mgrInstance);

		if (gameObject.name == "targetBoardSmall(Clone)") {
		
			mgrInstance.countTargetHit();
			//spawnMgr.countTargetHit();
			print ("destroying smalltarget");
		};
		if (gameObject.name == "kitty(Clone)") {

			mgrInstance.countKittyHit();
			//spawnMgr.countTargetHit();
			print ("destroying kitty!");
		};
		*/

		Destroy (gameObject);
	}


}