using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class DropDown : MonoBehaviour
{
	public TextMeshProUGUI output;
	
   
   public void HandleInputData(int val)
   {
	   if(val == 0 )
	   {
		    SceneManager.LoadScene("ExpDescr");
	   }
	   if(val == 1 )
	   {
		    SceneManager.LoadScene("ExpDescrChemistry");
	   }
   }


}
