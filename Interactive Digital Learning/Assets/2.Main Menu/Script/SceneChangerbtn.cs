using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerbtn: MonoBehaviour
{
   public void GotoMainScene(){
        SceneManager.LoadScene("1. MainMenu");
    }

   public void Goto_encyScene(){
        SceneManager.LoadScene("_ency");
    }


  
// ******************Chemistry apparatuses scenes******************************//
    public void BeakerScene(){
        SceneManager.LoadScene("Beaker");
    }

    public void BeeHiveFilterScene(){
        SceneManager.LoadScene("Beehivefilter");
    }

// ******************Chemistry apparatuses scenes******************************//
    public void RetortStandScene(){
        SceneManager.LoadScene("retort");
    }
   
}
