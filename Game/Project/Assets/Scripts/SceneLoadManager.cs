using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadManager : MonoBehaviour
{
    public static SceneLoadManager instance;

    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(gameObject);

        SceneManager.sceneLoaded += SceneLoaded;

        if(instance == null)
        {
            instance = this;
        } else if(instance != this)
        {
            Destroy(gameObject);
        }

    }

    private void SceneLoaded(Scene loadedScene, LoadSceneMode loadMode)
    {
        if (loadedScene.name == "GameScene")
        {
            Time.timeScale = 1f;
        }
    }
}
