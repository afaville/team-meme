using UnityEngine;
using System.Collections;
/******************************************************************************
 * @author Judson James
 * @version 1.0
 * @since 10-28-16 
 * Purpose: To Make Enemies Move and Stuff
**/
public class EnemyMove : MonoBehaviour {

    // Public Variables
    public Rigidbody2D rb;
    public Transform player;
    public float moveSpeed = 0.0f;
    public float minDist = 0.0f;
    public float maxDist = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.LookAt(player);
        if (Vector2.Distance(transform.position, player.position) >= minDist)
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }
        //transform.position = Vector2.MoveTowards(transform.position,
        //                     rb.position, moveSpeed);
	}
}
