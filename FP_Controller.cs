using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FP_Controller : MonoBehaviour {

	public float movementSpeed = 5.0F;
	public float upDownRange = 90.0F;
	public AudioSource audio;
	public int health = 10;

	// Update is called once per frame
	void Update () {
		float rotLeftRight = Input.GetAxis ("Mouse X") * 2.0F;
		//float rotUpDown = Input.GetAxis ("Mouse Y") * 2.0F;
		transform.Rotate (0, rotLeftRight, 0);
		float forwardSpeed = Input.GetAxis ("Vertical") * movementSpeed;
		float sideSpeed = Input.GetAxis ("Horizontal") * movementSpeed;

		Vector3 speed = new Vector3(sideSpeed,0.5f,forwardSpeed);
		speed = transform.rotation * speed;
		CharacterController cc = GetComponent<CharacterController>();
		cc.SimpleMove (speed);
	}
}
