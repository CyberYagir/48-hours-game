using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TV : MonoBehaviour
{
    public List<VideoClip> videoClips = new List<VideoClip>();
    public VideoPlayer videoPlayer;
    private void Start()
    {
        rnd();
    }
    public void rnd()
    {
        videoPlayer.clip = videoClips[Random.Range(0, videoClips.Count)];
    }
    private void Update()
    {
        videoPlayer.playbackSpeed = Time.timeScale;
        videoPlayer.SetDirectAudioVolume(0, 0.2f);   
    }
}
