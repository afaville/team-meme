using UnityEngine;
using System.Collections;
/******************************************************************************
 * Author: Judson James
 * Date Started: 10/16/16
 * Purpose: General Movement Code for Test Scene
**/

public class BoolMove : MonoBehaviour {
    // Instance Variables
    public int horizontalChange = 0;
    public int jumpHeight = 0;
    public float speed = 0;
    // void Start() : Use this for initialization *****************************
    void Start () {
	
	}

    // void Update() : Update is called once per frame ************************
    void Update () {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        if (vertical < 0)
        {
            vertical = 0;
        }
        horizontal = horizontal * Time.deltaTime * horizontalChange * speed;
        vertical = vertical * Time.deltaTime * jumpHeight * speed;
        transform.Translate(horizontal, 0, 0);
        transform.Translate(0, vertical, 0);
        
        /*
        // Movement from directional keys
        if (Input.GetKeyDown(KeyCode.A))
        {
            Vector3 position = this.transform.position;
            position.x = position.x - horizontalChange; // Left
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Vector3 position = this.transform.position;
            position.x = position.x + horizontalChange; // Right
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 position = this.transform.position;
            position.y = position.y + jumpHeight; // Up
            this.transform.position = position;
        }
        */
    }
}
