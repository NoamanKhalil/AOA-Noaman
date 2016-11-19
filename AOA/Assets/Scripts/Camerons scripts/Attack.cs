using UnityEngine;
using System.Collections;

public class Attack : NodeCs {



	public override void currentBehaviour () 
	{

		GameObject[] allTurrets = GameObject.FindGameObjectsWithTag ("Turret"); 


		foreach (GameObject turret in allTurrets)
		{

			if (ownerTree.transform.position == turret.transform.position) 
			{
				isRunning ();
				ownerTree.InvokeRepeating ("AttackTurret",1f,2f);
			}

			else 
			{
				hasFailed();
			}
		}




	}

	public void AttackTurret()
	{
		ownerTree.GetComponent<TowerBehaviour>().health -=  ownerTree.GetComponent<enemyBehaviour>().health;
	}
}
