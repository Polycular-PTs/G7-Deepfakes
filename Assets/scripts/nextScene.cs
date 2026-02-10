using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class nextScene : MonoBehaviour
{
    public string szenenName;

    public void nextChapter()
    {
        SceneManager.LoadScene(szenenName);
    }

    public void LoadNewScene(string szenenName)
    {
        SceneManager.LoadScene(szenenName);
    }
}
