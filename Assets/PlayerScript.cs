using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public GameObject leftLeg,rightLeg,leftArm,rightArm;

	private HingeJoint leftLegJoint, rightLegJoint, leftArmJoint, rightArmJoint;
	// Use this for initialization
	void Start () {
		leftLegJoint = leftLeg.GetComponent<HingeJoint> ();
		rightLegJoint = rightLeg.GetComponent<HingeJoint> ();
		leftArmJoint = leftArm.GetComponent<HingeJoint> ();
		rightArmJoint = rightArm.GetComponent<HingeJoint> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.D)) {
			leftLegJoint.motor.force = 100;
		}
		if (Input.GetKeyDown (KeyCode.F)) {
			leftArmJoint.motor.force = 100;
		}
		if (Input.GetKeyDown (KeyCode.J)) {
			rightArmJoint.motor.force = 100;
		}
		if (Input.GetKeyDown (KeyCode.K)) {
			rightLegJoint.motor.force = 100;
		}
	}
}
