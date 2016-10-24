using UnityEngine;
using System.Collections;
/*************************************
 * Author: Joshua Bush
 * Date Started: 10/23/16
 * Purpose: Generate a new bullet and set it's direction to the players facing direction
 */

public class JoshWeapon : MonoBehaviour {

    public GameObject bullet;

    private BoolMove BoolMove;
	// Use this for initialization
	void Start () {
        BoolMove = GetComponent<BoolMove>();
	
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.J))
        {
            var tBullet = Instantiate(bullet, gameObject.transform.position, bullet.transform.rotation) as GameObject;
            tBullet.GetComponent<JoshBullet>().bulletDirection = BoolMove.PlayerDirection;
        }
	
	}
}
