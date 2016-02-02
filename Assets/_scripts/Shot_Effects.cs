using UnityEngine;
using System.Collections;

public class Shot_Effects : MonoBehaviour {
	public GameObject parent;
	public GameObject fireworksExplosion;
	public GameObject gibletExplosion;

	// Use this for initialization
	void Start () {
	 
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void explodeWithGiblets()
	{
		//instantiate giblets prefab. Prefab will send things outward and have particle effects

		if( LaserSystem.mainLaser.myState == LaserSystem.LaserState.firing)
		{
		//turn off mesh of parent object. 
		Renderer rend = parent.GetComponent<Renderer>();
		rend.enabled = false;

		}

	}


	void explodeFireworks()
	{

		if( LaserSystem.mainLaser.myState == LaserSystem.LaserState.firing)
		{
			print(LaserSystem.mainLaser.myState);

			//Instantiate explosion prefab. 
			Instantiate(fireworksExplosion, parent.transform.position, Quaternion.identity);
			print ("explodingFireworks parent = " + parent.GetType().ToString() );


			//deactivate parent
			if ( parent.GetType() == typeof(spawnTarget) ) {
			
				print ("Parent object spawnTarget");
			} else if ( parent.GetType() == typeof(spawnCuties) ) {

				print ("Parent Object is spawnCuties");
			}

			//turn off mesh of parent object. 
			Renderer rend = parent.GetComponent<Renderer>();
			rend.enabled = false;
			parent.SetActive(false);
		}


	}
}
