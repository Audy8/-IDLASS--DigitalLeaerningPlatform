using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitGame : MonoBehaviour
{
    // Just to make sure it working 
    public void ExitGame(){
    UnityEngine.Debug.LogError("Exit Game");
    Application.Quit();	
    }
    
}
