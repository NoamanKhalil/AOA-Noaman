using UnityEngine;
using System.Collections;

public class enemyController : MonoBehaviour {

	public int currentEnemyHealth;
	public int totalEnemyHealth;

	public int enemyDamage;
	public int enemyDefense;
	public Vector3 enemySpeed;

	int enemyValue;

	float maxEnemySpeed;

	public int getEnemyDamage()
	{
		return enemyDamage;
	}
	public void getAndTakeDamage(int dmg)
	{
		currentEnemyHealth -= dmg;
	}

	void OnCollisionEnter(Collision player)
	{
		if (player.gameObject.tag == "Player") 
		{
			player.gameObject.GetComponent<PlayerOperator>().getAndTakeDamage(enemyDamage);
		}
	}

	// Use this for initialization
	void Start () {
		enemyValue = 100;
	}
	void Die()
	{
		GameObject.Find ("GameManager").GetComponent<GameManager> ().HandleScore (enemyValue);
		Destroy (gameObject);
	}

	
	// Update is called once per frame
	void Update () {
		if (currentEnemyHealth == 0) 
		{
			Die ();
		}
	
	}
}
