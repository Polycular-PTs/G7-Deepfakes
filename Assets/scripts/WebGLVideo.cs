using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System.IO;

public class WebGLVideo : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string videoName = "intro_v01.mp4";

    void Start()
    {
        
        if (videoPlayer == null) {
            videoPlayer = GetComponent<VideoPlayer>();

        }
        if (videoPlayer != null)
        {
            Debug.Log(videoName);
            videoPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath, videoName);
        }
        else
        {
            Debug.LogError("No VideoPlayer found!");
        }

    }
}
