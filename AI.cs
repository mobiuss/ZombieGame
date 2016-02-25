using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {

	GameObject player;
	Spawn spawn;

	public int health = 5;
	public AudioClip audioDead;
	public AudioSource audio;
	public bool isDead;
	public float randomPitch;


	// Use this for initialization
	void Start () {
		spawn = GameObject.Find ("Spawn").GetComponent<Spawn> ();
		player = GameObject.Find ("Player");
		randomPitch = Random.Range(-3f, 3f);
		audio.pitch = randomPitch;
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<NavMeshAgent>().destination = player.transform.position + Vector3.one;
		if (isDead && !audio.isPlaying) {
			Destroy (this.gameObject);
			spawn.EnemyCount--;
		}
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.name.Equals ("Bullet(Clone)") && audio.clip.name.Equals ("zombie")) {
			if (health == 0) {
				audio.clip = audioDead;
				audio.pitch = 1;
				audio.loop = false;
				audio.Play ();
				isDead = true;
			} else {
				health--;
			}
			Destroy (col.gameObject);
		}
	}
}
