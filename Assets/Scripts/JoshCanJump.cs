using UnityEngine;
using System.Collections;

public class JoshCanJump : MonoBehaviour {
    private bool grounded = true;

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Ground")
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }
    }

    public bool getGrounded()
    {
        return grounded;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
