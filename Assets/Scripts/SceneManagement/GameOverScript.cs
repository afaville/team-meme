using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; // The Whole Point of this Script
/******************************************************************************
 * @author Judson James
 * @since 10-26-16
 * @version 1.0
 * Purpose: If the Game Object touches the affected Game Object, the scene
 *          should move to the GameOver screen, will be modified to make
 *          it easier to move from scene to scene.
**/

public class GameOverScript : MonoBehaviour {

    public static int gameOverNumber = 1;
    public GameObject go;
    public Rigidbody2D rb;
    public Scene scene = SceneManager.GetSceneAt(gameOverNumber);
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (rb.IsTouchingLayers(LayerMask.GetMask("Dead")))
        {
            SceneManager.LoadScene(gameOverNumber);
            SceneManager.MoveGameObjectToScene(go, scene);
        }
	}
}
