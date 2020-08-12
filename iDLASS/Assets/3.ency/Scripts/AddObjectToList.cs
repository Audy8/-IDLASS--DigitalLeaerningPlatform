using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddObjectToList : MonoBehaviour
{	
	int index = 0;
     public static bool disabled = false;
	 public GameObject itemTemplete;
	 public GameObject content;

// Game objects apparatuses
	 public GameObject BeeHiveFilter;
	 public GameObject BunsenBurner;
	 public GameObject Condenser;
	 public GameObject ConicalFlask;
	 public GameObject Crucible;
	 public GameObject Flask_01;


	void Start()
	{
		//DestroyObjects();
	}



	 public void addButton_Click(){
	 	var copy = Instantiate(itemTemplete);
	 	copy.transform.parent = content.transform;

	 	copy.GetComponentInChildren<Text>().text = (index+1).ToString();

	 	int copyOfIndex = index;
	 	if (copyOfIndex==0){
				copy.GetComponentInChildren<Text>().text = "BeeHive Filter";
				copy.GetComponentInChildren<Text>().text = "BunsenBurner";
				copy.GetComponentInChildren<Text>().text = "ConicalFlask";
				copy.GetComponentInChildren<Text>().text = "Conical Flask";
				copy.GetComponentInChildren<Text>().text = "Crucible";
				copy.GetComponentInChildren<Text>().text = "Flask_01";
	 			}
		
	 	copy.GetComponent<Button>().onClick.AddListener(

	 		()=>
	 		{
	 			// TODO: Anything you need for the current index
	 			Debug.Log("index number"+ copyOfIndex);
	 			switch(copyOfIndex)
	 			{   
	 				case 0:
	 				//DestroyObjects();
	 				if(disabled)
	 				BeeHiveFilter.SetActive(false);
	 				else
	 				BeeHiveFilter.SetActive(true);
	 				break;

	 				case 1:
	 				//DestroyObjects();
	 				if(disabled)
	 				BunsenBurner.SetActive(false);
	 				else
	 				BunsenBurner.SetActive(true);
	 				break;
	 			}

	 		}

	 		);

	 	index++;
	 }

	public void DestroyObjects(){
	 	string tag= "Apparatus";
	 	GameObject[] gameobject = GameObject.FindGameObjectsWithTag (tag);
	 	foreach(GameObject target in gameobject)
	 	{
	 		GameObject.Destroy(target);
	 	}
	 }


}
