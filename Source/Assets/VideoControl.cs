using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoControl : MonoBehaviour
{
    public void PlayVideo(string filename)
    {
        VideoPlayer videoPlayer = this.GetComponent<VideoPlayer>();
        videoPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath, filename);
        videoPlayer.Play();
    }
}
