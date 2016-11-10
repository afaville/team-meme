using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; // The Whole Point of this Script
/******************************************************************************
 * @author Judson James
 * @version 1.0
 * @since 10-28-16
 * Purpose: Read Class Name
**/
public class ToEnemyLevel : MonoBehaviour {

    private static int SceneNumber = 3;
    public string LayerName = "";
    public GameObject go;
    public Rigidbody2D rb;
    public Scene scene = SceneManager.GetSceneAt(SceneNumber);

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (rb.IsTouchingLayers(LayerMask.GetMask(LayerName)))
        {
            SceneManager.LoadScene(5);
            SceneManager.MoveGameObjectToScene(go, scene);
        }
    }
}
