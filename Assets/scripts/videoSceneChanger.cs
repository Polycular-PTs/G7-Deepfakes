using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoSceneChanger : MonoBehaviour
{
    public VideoPlayer myVideoPlayer;
    public string videoName = "intro_v01.mp4";
    public string nextSceneName;

    void Start()
    {
        myVideoPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath, videoName);
        myVideoPlayer.loopPointReached += LoadNextScene;
    }

    void LoadNextScene(VideoPlayer vp)
    {
        SceneManager.LoadScene(nextSceneName);
    }

    void OnDestroy()
    {
        myVideoPlayer.loopPointReached -= LoadNextScene;
    }
}