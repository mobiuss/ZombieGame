using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public Rigidbody projectile;
	public float speed = 20;
	public Transform bulletSpawn;
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetButtonDown ("Fire1"))
		{
			Rigidbody newProjectile = Instantiate (projectile, bulletSpawn.transform.position, bulletSpawn.transform.rotation) as Rigidbody;
			newProjectile.velocity = transform.TransformDirection (new Vector3 (0, 0, speed));
		}
	}
}
