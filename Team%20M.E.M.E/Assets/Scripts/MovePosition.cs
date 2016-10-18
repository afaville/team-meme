using UnityEngine;
using System.Collections;
/******************************************************************************
 * Author: Judson James
 * Date Started: 10/16/16
 * Purpose: General Movement Code for Test Scene
**/
public class MovePosition : MonoBehaviour {
    // Instance Variables
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    private Vector3 moveDirection = Vector3.zero;
    // void Start() : Use this for initialization *****************************
    void Start () {
        
	}

    // void Update() : Update is called once per frame ************************
    void Update () {
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded) {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 
                                        Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump")) {
                moveDirection.y = jumpSpeed;
            }
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
	}
}
