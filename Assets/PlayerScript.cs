using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public GameObject leftLeg,rightLeg,leftArm,rightArm;

	private JointMotor leftLegJoint, rightLegJoint, leftArmJoint, rightArmJoint;

	public float speed;
	// Use this for initialization
	void Start () {
		leftLegJoint = leftLeg.GetComponent<HingeJoint> ().motor;
		rightLegJoint = rightLeg.GetComponent<HingeJoint> ().motor;
		leftArmJoint = leftArm.GetComponent<HingeJoint> ().motor;
		rightArmJoint = rightArm.GetComponent<HingeJoint> ().motor;
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
		leftLeg.GetComponent<HingeJoint> ().motor = leftLegJoint;
		rightLeg.GetComponent<HingeJoint> ().motor = rightLegJoint;
		leftArm.GetComponent<HingeJoint> ().motor = leftArmJoint;
		rightArm.GetComponent<HingeJoint> ().motor = rightArmJoint;
	}
}
