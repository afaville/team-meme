using UnityEngine;
using System.Collections;
/******************************************************************************
 * Author: Judson James
 * Date Started: 10/16/16
 * Purpose: General Movement Code for Test Scene
 * Author: Joshua Bush
 * Date edited: 10/23/16; 10/24/16
 * Purpose: Changing the jump to an add force; Added a collision detection to the jump
**/

public enum Direction {LEFT, RIGHT};

public class BoolMove : MonoBehaviour {
    // Instance Variables
    public int horizontalChange = 0;
    public int jumpHeight = 0;
    public float speed = 0;
    public float thrust = 0;
    public Rigidbody2D rb;

    private Direction playerDirection = Direction.RIGHT;

    public Direction PlayerDirection
    {
        get
        {
            return playerDirection;
        }
    }
    // void Start() : Use this for initialization *****************************
    void Start () {
	
	}

    // void Update() : Update is called once per frame ************************
    void Update () {

        float horizontal = Input.GetAxis("Horizontal");
        //float vertical = Input.GetAxis("Vertical");
        /*
        if (vertical < 0)
        {
            vertical = 0;
        }*/
        horizontal = horizontal * Time.deltaTime * horizontalChange * speed;
        //vertical = vertical * Time.deltaTime * jumpHeight * speed;
        transform.Translate(horizontal, 0, 0);
        //transform.Translate(0, vertical, 0);

        if(horizontal > 0)
        {
            playerDirection = Direction.RIGHT;
        }
        else if(horizontal < 0)
        {
            playerDirection = Direction.LEFT;
        }


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
        */
        if (Input.GetKeyDown(KeyCode.Space))
        {
            /*Checks if the rigidbody is touching anything that is on the layer "Ground"
             * You can add items to this layer in unity
             * Not sure if this will cause issues later on but for now it works 
             */
            if (rb.IsTouchingLayers(LayerMask.GetMask("Ground")))
            {
                rb.AddForce(transform.up * thrust);
            }
            /*
            Vector3 position = this.transform.position;
            position.y = position.y + jumpHeight; // Up
            this.transform.position = position;
            */
        }
        
    }
}
