using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class VideoManger : MonoBehaviour
{
	public VideoClip[] VideoClips; 
	public int CurrentVideo = 0;
	VideoPlayer videoPlayer;
	AudioSource audioSource;
	bool isPlaying = false;

    // Start is called before the first frame update
    void Start()
    {
    	videoPlayer = GetComponent<VideoPlayer>();
    	audioSource =GetComponent<AudioSource>();
        videoPlayer.clip = VideoClips[CurrentVideo];
        videoPlayer.SetTargetAudioSource(0,audioSource);
    }

    void Play(){
    	videoPlayer.Play();
    	audioSource.Play();
    	isPlaying = true;
    }

    void Pause(){
    	audioSource.Pause();
    	videoPlayer.Pause();
    	isPlaying = false;
    }

    void Next(){
    	if(CurrentVideo == VideoClips.Length -1)
    	CurrentVideo =0;
    	else
    	CurrentVideo++;
    	videoPlayer.clip = VideoClips[CurrentVideo];
    	videoPlayer.SetTargetAudioSource(0,audioSource);
    	if(isPlaying)
    		Play();
    }

    void Prev(){
    	if(CurrentVideo==0)
    	CurrentVideo = VideoClips.Length -1;
    	else
    	CurrentVideo--;
    	videoPlayer.clip = VideoClips[CurrentVideo];
    	videoPlayer.SetTargetAudioSource(0,audioSource);
    	if(isPlaying)
    		Play();
    }

    void Mute(){
    	audioSource.mute = true;
    }

    void UnMute(){
    	audioSource.mute = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
