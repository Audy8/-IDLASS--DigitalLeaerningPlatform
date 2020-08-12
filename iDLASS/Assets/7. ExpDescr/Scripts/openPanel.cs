using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openPanel : MonoBehaviour
{
    public GameObject gameObject;
	bool active;
	
	public void OpenPanel()
	{
		gameObject.transform.gameObject.SetActive(true);
		active= true;
	}
}
