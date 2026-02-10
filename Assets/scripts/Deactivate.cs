using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Deactivate : MonoBehaviour
{
    public Animator anim;

    public Button buttonToActivate;

    public GameObject go;
    public string sceneName;

    void Deativate()
    {
        if (anim != null)
        {
            anim.enabled = false;
        }
    }

    void ActivateButton()
    {
        if (buttonToActivate != null)
        {
            Debug.Log("Test " + buttonToActivate.name);
            buttonToActivate.interactable = true;
        }
    }

    void ActivateGameObject()
    {
        if (go != null)
        {
            go.SetActive(true);
        }
    }

    void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
