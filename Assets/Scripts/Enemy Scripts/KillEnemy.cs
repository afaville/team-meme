using UnityEngine;
using System.Collections;
/******************************************************************************
 * @author Judson James
 * @version 1.0
 * @since 10-27-16
 * Purpose: Destroys the enemy if it is touching a "Dead" layer
**/
public class KillEnemy : MonoBehaviour {

    // Public Variables
    public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (rb.IsTouchingLayers(LayerMask.GetMask("Dead")))
        {
            Destroy(this.gameObject);
        }	    
	}
}
