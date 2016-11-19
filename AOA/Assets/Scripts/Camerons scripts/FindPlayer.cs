using UnityEngine;
using System.Collections;

public class FindPlayer : NodeCs {

	public GameObject player; 


	public override void currentBehaviour () 
	{
		player = GameObject.FindGameObjectWithTag ("Player"); 

		if (player != null) 
		{
			//ownerTree.GetComponent<Unit> ().requestPath (player.transform);
		}
	}
}
