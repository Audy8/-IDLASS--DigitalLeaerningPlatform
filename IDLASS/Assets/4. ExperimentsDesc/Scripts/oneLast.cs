using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oneLast : MonoBehaviour
{
   public Transform pivot;
 private float angle;
 private Vector3 v3Pivot;  // Pivot in screen space
 
 void Start () {
    v3Pivot = Camera.main.WorldToScreenPoint (pivot.position);
  }
 
 void OnMouseDown() {
    Vector3 v3T = (Vector3)Input.mousePosition - v3Pivot;
    angle = Mathf.Atan2 (v3T.y, v3T.x) * Mathf.Rad2Deg;
 }
 
 void OnMouseDrag() {
    Vector3 v3T = (Vector3)Input.mousePosition - v3Pivot;
    float angleT  = Mathf.Atan2 (v3T.y, v3T.x)  * Mathf.Rad2Deg;
    float angleDiff = Mathf.DeltaAngle(angle, angleT);
    pivot.Rotate(new Vector3(0.0f, 0.0f, angleDiff));
    angle = angleT;
 }
}
