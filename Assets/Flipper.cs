using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour {

	public GameObject pyrsto;
	public GameObject FL;
	public GameObject FR;

	private JointMotor hj;
	private JointMotor FLmotor;
	private JointMotor FRmotor;

	public float target;
	// Use this for initialization
	void Start () {
		hj = pyrsto.GetComponent<HingeJoint> ().motor;
		FLmotor = FL.GetComponent<HingeJoint> ().motor;
		FRmotor = FR.GetComponent<HingeJoint> ().motor;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			hj.targetVelocity = target;
		
		}
		if (Input.GetKey (KeyCode.P)) {
			hj.targetVelocity = -target;

		}
		if (Input.GetKey (KeyCode.H)) {
			FLmotor.targetVelocity = -target;

		}
		if (Input.GetKey (KeyCode.J)) {
			FRmotor.targetVelocity = -target;

		}
		if (Input.GetKeyUp (KeyCode.Space)) {
			hj.targetVelocity = 0;

		}
		if (Input.GetKeyUp (KeyCode.P)) {
			hj.targetVelocity = 0;

		}
		if (Input.GetKeyUp (KeyCode.H)) {
			FLmotor.targetVelocity = 0;

		}
		if (Input.GetKeyUp (KeyCode.J)) {
			FRmotor.targetVelocity = 0;

		}
		pyrsto.GetComponent<HingeJoint> ().motor = hj;
		FL.GetComponent<HingeJoint> ().motor = FLmotor;
		FR.GetComponent<HingeJoint> ().motor = FRmotor;
	}
}
