using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static int currentLevel;

    private static EditorBuildSettingsScene[] levelList;
    private static int maxLevel;



    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
         levelList = EditorBuildSettings.scenes;
         maxLevel = levelList.Length;
    }

    public void RestartLevel(float delay)
    {
        StartCoroutine(RestartLevelDelay(delay));
    }

    private IEnumerator RestartLevelDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        if (currentLevel < maxLevel)
        {
            currentLevel++;
        }
        else
        {
            currentLevel = 0;
        }
        //SceneManager.LoadScene("Game");
        SceneManager.LoadScene(currentLevel);
    }


}

