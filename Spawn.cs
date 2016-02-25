using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	public int EnemyCount;
	int maxEnemyCount;
	public GameObject enemy;
	public GameObject spawn;

	// Use this for initialization
	void Start () {
		EnemyCount = 1;
		maxEnemyCount = 5;
		spawn = GameObject.Find ("Spawn");
	}
	
	// Update is called once per frame
	void Update () {
		if (EnemyCount < maxEnemyCount) {
			Instantiate(enemy, spawn.transform.position, Quaternion.identity);
			EnemyCount++;
		}
	}
}
