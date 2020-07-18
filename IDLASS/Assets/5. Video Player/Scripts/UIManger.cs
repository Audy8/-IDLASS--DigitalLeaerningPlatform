using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManger : MonoBehaviour
{
	public GameObject PlayButton;
	public GameObject PauseButton;
	public GameObject MuteButton;
	public GameObject UnMuteButton;
	public GameObject NextButton;
	public GameObject PrevButton;

	public GameObject VideoManager;
    // Start is called before the first frame update
    void Start()
    {
        PlayButton.SetActive(true);
        PauseButton.SetActive(false);

        MuteButton.SetActive(true);
        UnMuteButton.SetActive(false);

        NextButton.SetActive(true);
        PrevButton.SetActive(true);
    }

    public void play(){
    	PlayButton.SetActive(false);
    	PauseButton.SetActive(true);

    	//Play video
    	VideoManager.SendMessage("Play");
    }

    public void Pause(){
		PlayButton.SetActive(true);
    	PauseButton.SetActive(false);

    	//Pause video
    	VideoManager.SendMessage("Pause");
    }

    public void Mute(){
    	 MuteButton.SetActive(false);
        UnMuteButton.SetActive(true);

        //Mute video
    	VideoManager.SendMessage("Mute");
    }

    public void UnMute(){
    	 MuteButton.SetActive(true);
        UnMuteButton.SetActive(false);

        //UnMute video
    	VideoManager.SendMessage("UnMute");
    }

    public void Next(){
    	
    	//Next video
    	VideoManager.SendMessage("Next");
    }

    public void prev(){

    	//prev video
    	VideoManager.SendMessage("prev");
    }

}
