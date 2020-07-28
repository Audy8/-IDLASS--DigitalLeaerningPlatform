using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowModelUI : MonoBehaviour
{
	[SerializeField] private ShowModelButton buttonPrefab;

	private void Start ()
	{
		var models = FindObjectOfType<ShowModelController>().GetModels();
		foreach (var model in models)
		{
			CreatButtonForModel(model);
		}
	}

	private void CreatButtonForModel(Transform model){
		var button = Instantiate(buttonPrefab);
		button.transform.SetParent(this.transform);
		button.transform.localScale = Vector3.one;
		button.transform.localRotation = Quaternion.identity;

		button.Initialize(model, FindObjectOfType<ShowModelController>().EnableModel);
	}
}