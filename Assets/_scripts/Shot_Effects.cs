using UnityEngine;
using System.Collections;

public class Shot_Effects : MonoBehaviour {
	public GameObject parent;
	public GameObject fireworksExplosion;
	public GameObject gibletExplosion;

	private objectDestroy destroyInstance;
	//private spawnTarget targetSpawnPoint;
	//private spawnCuties cutieInstance;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void explodeWithGiblets()
	{
		//instantiate giblets prefab. Prefab will send things outward and have particle effects


		//turn off mesh of parent object. 
		Renderer rend = parent.GetComponent<Renderer>();
		rend.enabled = false;



	}


	void explodeFireworks()
	{
		reportLaserConnect(transform.position);

		//Instantiate explosion prefab. 
		Instantiate(fireworksExplosion, parent.transform.position, Quaternion.identity);
		destroyInstance = parent.GetComponent<objectDestroy> () as objectDestroy;

		if ( destroyInstance != null ) {		
			destroyInstance.destroyObject();
		}


		//turn off mesh of parent object. 
		/*
		Renderer rend = parent.GetComponent<Renderer>();
		rend.enabled = false;
		parent.SetActive(false);
		*/

	}

	void reportLaserConnect(Vector3 myPos)
	{
		LaserSystem.mainLaser.fireAtTarget(myPos);

	}
}
