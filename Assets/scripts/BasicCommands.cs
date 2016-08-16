using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BasicCommands : MonoBehaviour {

    public void loadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
