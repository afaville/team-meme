using UnityEngine;
using System.Collections;
/******************************************************************************
 * Author: Judson James
 * Date Started: 10/16/16
 * Purpose: General Movement Code for Test Scene
 * Author: Joshua Bush
 * Date edited: 10/23/16;
 *              10/24/16;
 *              11/1/16;
 * Purpose: Changing the jump to an add force;
 *          Added a collision detection to the jump;
 *          Changed the movement system to an addforce, added statments that
 *          will stop the movement when no keys are being pressed unless player
 *          is in the air, changed the input from the horizontal access to 
 *          keypresses;
 */

public enum Direction {LEFT, RIGHT};

public class BoolMove : MonoBehaviour {
    // Instance Variables
    public int horizontalChange = 0;
    public int jumpHeight = 0;
    public float speed = 5;
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
        //Gets he current velocity in the x axis
        float xVel = transform.InverseTransformDirection(rb.velocity).x;
        float horizontal = Input.GetAxis("Horizontal");
        //Subtracts the absolute value of the vel from the speed set
        float tempSpeed = speed - Mathf.Abs(xVel);

        if(Input.GetKey(KeyCode.D))
        {
            playerDirection = Direction.RIGHT;
            rb.AddForce(transform.right * tempSpeed);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            playerDirection = Direction.LEFT;
                rb.AddForce(transform.right * -tempSpeed);
        }

        /*Checks when the input keys are no longer pressed or when the horizontal 
         * input is 0 (added the horizontal because GetKeyUp only is true on the
         * frame that the key is lifted, so if the character is jumping he would
         * keep rolling after the jump)
         * Then checks if the player is on the ground and if he is then zeros out
         * the velocity in the x axis
         */
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D) || horizontal == 0)
        {
            if (rb.IsTouchingLayers(LayerMask.GetMask("Ground")))
            {
                Vector2 tempVect = new Vector2(0, rb.velocity.y);
                rb.velocity = tempVect;
            }
        }



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
        }
        
    }
}
