using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using HoloToolkit.Unity.InputModule;

public class VideoPlayPause : MonoBehaviour, IInputClickHandler {

    private VideoPlayer videoPlayer;
    private AudioSource audioSource;

    private void Awake()
    {
        videoPlayer = this.gameObject.GetComponent<VideoPlayer>();
        audioSource = this.gameObject.GetComponent<AudioSource>();

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayPause()
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
            audioSource.Pause();
        }

        else
        {
            videoPlayer.Play();
            audioSource.Play();
        }
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        PlayPause();
    }
}
