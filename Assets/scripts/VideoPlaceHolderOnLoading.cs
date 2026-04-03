using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlaceHolderOnLoading : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject loadingObject;

    private bool videoReady = false;

    void Start()
    {
        loadingObject.SetActive(true);

        videoPlayer.prepareCompleted += OnVideoPrepared;
        videoPlayer.Prepare();
        videoPlayer.Play();
    }

    private void Update()
    {
        if (!videoReady && videoPlayer.texture != null)
        {
            videoReady = true;
            loadingObject.GetComponent<Animator>().SetTrigger("TurnOff");
            //loadingObject.SetActive(false);
        }
    }

    void OnVideoPrepared(VideoPlayer vp)
    {
        videoReady = true;
        loadingObject.GetComponent<Animator>().SetTrigger("TurnOff");
    }
}
