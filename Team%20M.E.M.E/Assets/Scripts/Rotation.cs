using UnityEngine;
using System.Collections;
/******************************************************************************
 * Author: Judson James
 * Date: 10-17-16
 * Purpose: Stop ALL rotation.
**/
public class Rotation : MonoBehaviour {

    // Instance Variables
    public bool rotationAllToggle = false;
    public bool rotationXToggle = false;
    public bool rotationYToggle = false;
	
    // void Start() : Use this for initialization
	void Start() {
	
	}
	
	// void Update() : Update is called once per frame
	void Update() {
	    if (rotationAllToggle == true) {
            GetComponent<Rigidbody2D>().freezeRotation = true;
        }
        if (rotationXToggle == true) {
            GetComponent<Rigidbody2D>().freezeRotation = true;
        }
        if (rotationYToggle == true) {
            GetComponent<Rigidbody2D>().freezeRotation = true;
        }
	}
}
