using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ControlVideo : MonoBehaviour
{

    public VideoPlayer video;

    private void RepVideo()
    {
        video = GetComponent<VideoPlayer>();
        video.Play();
        video.loopPointReached += CheckOver;

       
    }

    void CheckOver(VideoPlayer vp)
    {
        gameObject.SetActive(false);

    }
}
