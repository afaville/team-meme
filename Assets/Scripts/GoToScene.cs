using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; // The Whole Point of this Script
/******************************************************************************
 * @author Judson James
 * @since 10-26-16
 * @version 1.0
 * Purpose: An easy to use "go to this scene" script that uses a number from
 *          the build settings.
**/

public class GoToScene : MonoBehaviour {

    public static int SceneNumber = 0;
    public string LayerName = "";
    public GameObject go;
    public Rigidbody2D rb;
    public Scene scene;

	// Use this for initialization
	void Start () {
        scene = SceneManager.GetSceneAt(SceneNumber);
}
	
	// Update is called once per frame
	void Update () {
        if (rb.IsTouchingLayers(LayerMask.GetMask(LayerName)))
        {
            SceneManager.LoadScene(SceneNumber);
            SceneManager.MoveGameObjectToScene(go, scene);
        }
    }
}
