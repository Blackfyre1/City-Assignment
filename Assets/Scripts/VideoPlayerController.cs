using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerController : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    [SerializeField]
    private List<VideoClip> Clips;
    private int index;
    void Start()
    {
        index = 0;
        videoPlayer = gameObject.GetComponent<VideoPlayer>();
        videoPlayer.clip = Clips[index];
    }
/* For a play/pause toggle button which changes what it does depending on whether the video is paused or playing.
    public void TogglePlayPause()
    {
        if(videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
        }
        else if (videoPlayer.isPaused)
        {
            videoPlayer.Play();
        }
    }
*/

    public void Play()
    {
        videoPlayer.Play();
    }

    public void Pause()
    {
        videoPlayer.Pause();
    }

    public void RePlay()
    {
        videoPlayer.Stop();
        videoPlayer.Play();
    }
    public void Next()
    {
        index++;
        index %= Clips.Count;
        videoPlayer.clip = Clips[index];
        videoPlayer.Play();
    }
    public void Previous()
    {
        index--;
        if(index<0)
        {
            index += Clips.Count;
        }
        videoPlayer.clip = Clips[index];
        videoPlayer.Play();
    }
}
