using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAndClosePanel : MonoBehaviour
{
   
   public GameObject Panel;
   
   public void openpanel()
   {
	   if(Panel != null)
	   {
		   bool isActive = Panel.activeSelf;
		   
		   Panel.SetActive(!isActive);
	   }
   }
}
