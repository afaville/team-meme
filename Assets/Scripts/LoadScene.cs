using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    public void LoadByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
