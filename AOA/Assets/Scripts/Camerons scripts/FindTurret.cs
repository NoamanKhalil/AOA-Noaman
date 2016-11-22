using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class FindTurret : NodeCs
{
	public GameObject [] allTurrets;
	public Vector3[] pathToFollow; 
	private int count; 
	public float turretDistance;
	public GameObject closestTurret; 
	public float closestDistance;
	public bool hasPath;
	// Use this for initialization


	// Update is called once per frame

	public override void currentBehaviour()
	{

		count = 0;
		
		isRunning ();
		closestDistance = Mathf.Infinity;
		hasPath = false;

		Debug.Log ("Find Turret");
		
		allTurrets = GameObject.FindGameObjectsWithTag ("Turret");

		//closestDistance = Mathf.Infinity;
		if (hasPath == false) 
		{

			hasPath = true;
			
			foreach (GameObject turret in allTurrets) {
							Debug.Log ("yes" + allTurrets);
				//draws distance from all turrets and all enemies
				//Vector3 direction = transform.position - turret.transform.position;
				turretDistance = Vector3.Distance (ownerTree.transform.position , turret.transform.position); 


		 	 

				if (turretDistance < closestDistance) {
					closestDistance = turretDistance;
					hasPath = false;
					if (allTurrets [allTurrets.Length - 1]) {
						//hasPath = false;
						Debug.Log (hasPath);
						//ownerTree.GetComponent<Unit> ().requestPath (turret.transform);

					}

					if (pathToFollow.Length > 0)
					{
						foreach (Vector3 n in pathToFollow)
						{
							if (count < pathToFollow.Length) {
								ownerTree.transform.Translate (pathToFollow [count]);

								count++; 
							} 

							else 
							{
								break; 
							}
						}
					}

					isSuccessful ();
				} 
				else
				{
					hasFailed ();
				}

		
			}

		}
//		Debug.Log (closestDistance);



		}
	

}
