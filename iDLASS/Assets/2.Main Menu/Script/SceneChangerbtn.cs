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
	
    public void Goto_Experiments(){
        SceneManager.LoadScene("Experiments");
    }
	
	public void Goto_ExpDescr(){
        SceneManager.LoadScene("ExpDescr");
    }

  
// ******************Chemistry******************************//
    public void BeakerScene(){
        SceneManager.LoadScene("Beaker");
    }
	
	public void ExpDescrChemistryScene(){
        SceneManager.LoadScene("ExpDescrChemistry");
    }


// ******************Physics******************************//
    public void pendulum(){
        SceneManager.LoadScene("pendulum");
    }
   
}
