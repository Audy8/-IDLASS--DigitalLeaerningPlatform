using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAndClosePanel : MonoBehaviour
{
    public GameObject gameObject;
	public GameObject gameObject1;
	//public GameObject gameObject2;
	
	bool active;
	
	public void OpenPanelandClose()
	{
		
			gameObject.transform.gameObject.SetActive(true);
			active= true;
		
			gameObject1.transform.gameObject.SetActive(false);
			active= false;
			
			/*gameObject2.transform.gameObject.SetActive(false);
			active= false;*/
	}
}
