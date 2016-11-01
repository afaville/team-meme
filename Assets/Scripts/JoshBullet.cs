using UnityEngine;
using System.Collections;
/******************************************************************************
 * Author: Joshua Bush
 * Date Started: 10/23/16
 * Prupose: Move an object in a direction based on the direction a player
 *          is facing
 */

public class JoshBullet : MonoBehaviour {

    public Direction bulletDirection = Direction.RIGHT;
    public float speed = 5.0f;
    public float lifeTime = 5.0f;

    private Transform _transform;


	// Use this for initialization
	void Start () {
        _transform = transform;
	
	}
	
	// Update is called once per frame
	void Update () {
        int moveDirection;
        if(bulletDirection == Direction.LEFT)
        {
            moveDirection = -1;
        }
        else
        {
            moveDirection = 1;
        }

        float translate = moveDirection * speed * Time.deltaTime;
        _transform.Translate(translate, 0, 0);

        Destroy(this.gameObject,lifeTime);
	
	}
}
