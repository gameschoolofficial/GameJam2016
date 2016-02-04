using UnityEngine;
using System.Collections;

public class objectDestroy : MonoBehaviour {


	public void destroyObject(){
	
		print ("destroy - gameObject type = "+gameObject.GetType ());
		//if (gameObject.GetType () == "targetBoardSmall") {
		
		//	print ("destroying smalltarget");
		//};
		Destroy (gameObject);
	}


}