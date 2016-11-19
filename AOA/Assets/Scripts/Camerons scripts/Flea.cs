using UnityEngine;
using System.Collections;

public class Flea : NodeCs {


	public float closestSpawn = Mathf.Infinity;
	public bool hasPath;


	public override void currentBehaviour () 
	{
		GameObject[] fleaLocations = GameObject.FindGameObjectsWithTag ("SpawnLocation");
			
		//hasPath = false; 

			if (hasPath == false) 
			{

				hasPath = true;
				
				foreach (GameObject flea in fleaLocations) 
				{

					isRunning ();
				
					float fleaDistance = Vector3.Distance (ownerTree.transform.position, flea.transform.position);

					if (fleaDistance < closestSpawn) 
					{

						closestSpawn = fleaDistance; 

						//ownerTree.GetComponent<Unit> ().requestPath (flea.transform);

						if (fleaLocations [fleaLocations.Length - 1])
						{
							hasPath = false; 
						}
				
					} 

					else 
					{
						hasFailed ();
					}
				}
			}

	}
}
