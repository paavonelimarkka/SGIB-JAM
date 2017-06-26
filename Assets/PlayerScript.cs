using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public GameObject legFL,legFR,legBL, legBR;

	private JointMotor leftLegJoint, rightLegJoint, leftArmJoint, rightArmJoint;

	public float speed;
	// Use this for initialization
	void Start () {
		leftLegJoint = legBL.GetComponent<HingeJoint> ().motor;
		rightLegJoint = legBR.GetComponent<HingeJoint> ().motor;
		leftArmJoint = legFL.GetComponent<HingeJoint> ().motor;
		rightArmJoint = legFR.GetComponent<HingeJoint> ().motor;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.D)) {
			leftLegJoint.force = speed;
		}
		if (Input.GetKeyDown (KeyCode.F)) {
			leftArmJoint.force = speed;
		}
		if (Input.GetKeyDown (KeyCode.J)) {
			rightArmJoint.force = speed;
		}
		if (Input.GetKeyDown (KeyCode.K)) {
			rightLegJoint.force = speed;
		}
		if (Input.GetKeyUp (KeyCode.D)) {
			leftLegJoint.force = 0;
		}
		if (Input.GetKeyUp (KeyCode.F)) {
			leftArmJoint.force = 0;
		}
		if (Input.GetKeyUp (KeyCode.J)) {
			rightArmJoint.force = 0;
		}
		if (Input.GetKeyUp (KeyCode.K)) {
			rightLegJoint.force = 0;
		}
		legBL.GetComponent<HingeJoint> ().motor = leftLegJoint;
		legBR.GetComponent<HingeJoint> ().motor = rightLegJoint;
		legFL.GetComponent<HingeJoint> ().motor = leftArmJoint;
		legFR.GetComponent<HingeJoint> ().motor = rightArmJoint;
	}
}
