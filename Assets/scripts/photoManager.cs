using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class photoManager : MonoBehaviour
{

    public Button[] photoButtons;

    public VideoPlayer intro;

    public float triggerTime = 3.0f;

    public int score;
    public string loadSceneName = "05_01_scene2";

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForIntro(triggerTime));
    }

    // Update is called once per frame
    void Update()
    {
        if (score == 6)
        {
            SceneManager.LoadScene(loadSceneName);
        }
    }

    IEnumerator WaitForIntro (float timeinseconds)
    {
        yield return new WaitForSeconds(3);

        photoButtons[0].gameObject.SetActive(true);
        photoButtons[1].gameObject.SetActive(true);
        photoButtons[2].gameObject.SetActive(true);
        photoButtons[3].gameObject.SetActive(true);
        photoButtons[4].gameObject.SetActive(true);
        photoButtons[5].gameObject.SetActive(true);
        photoButtons[6].gameObject.SetActive(true);
        photoButtons[7].gameObject.SetActive(true);
        photoButtons[8].gameObject.SetActive(true);

        Debug.Log("Button Sind Aktiv");
    }


}
