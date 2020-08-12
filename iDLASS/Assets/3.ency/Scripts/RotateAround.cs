using UnityEngine;
using System.Collections;

public class RotateAround : MonoBehaviour {
    
   float speed = 20.0f;

 
    void Start () {
      

    }
	
	// Update is called once per frame
	void Update () {
       transform.Rotate(Vector3.up *speed* Time.deltaTime);
    }
    
}
