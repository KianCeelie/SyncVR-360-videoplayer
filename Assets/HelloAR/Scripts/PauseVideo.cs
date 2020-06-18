using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PauseVideo : MonoBehaviour
{
    private PauseMenu PauseMenu;
    public VideoPlayer Spherevideo;

    public void Resume()
    {
        Spherevideo.playbackSpeed = 1f;
    }

    public void Pause()
    { 
        Spherevideo.playbackSpeed = 0f;
    }

}
