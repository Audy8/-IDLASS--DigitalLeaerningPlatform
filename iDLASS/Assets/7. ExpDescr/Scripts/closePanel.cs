using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closePanel : MonoBehaviour
{
    public GameObject gameObject;
	bool active;
	
	public void ClosePanel()
	{
				gameObject.transform.gameObject.SetActive(false);
				active=false;
	}
}
