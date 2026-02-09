using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dragDropManager : MonoBehaviour
{
    public int dragDropScore;
    public string loadSceneName;

    void Update()
    {
        if (dragDropScore == 4)
        {
            SceneManager.LoadScene(loadSceneName);
        }
    }
}
