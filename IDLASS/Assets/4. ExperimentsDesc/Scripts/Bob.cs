using UnityEngine;
 using System.Collections;
 
 public class Bob : MonoBehaviour {
     
     public Transform pivot;
     public float    speed = 0.5f;
     private Vector3 v3Pivot;  // Pivot in screen space
     public bool    dragging = false;
     public float   startAngle = 0.0f;
     public float   endAngle = -180.0f;
     private float   fTimer = 0.0f;
     private float   angleDiff;
     private Vector3 v3T = Vector3.zero; 
     private float   angle;
 
     void Start () {
         v3Pivot = Camera.main.WorldToScreenPoint (pivot.position);
      }
     
     void Update() {
         if (!dragging) {
             float f = (Mathf.Sin (fTimer * speed - Mathf.PI / 2.0f) + 1.0f) / 2.0f ;
             
             v3T.Set (0.0f, 0.0f, Mathf.Lerp(startAngle, endAngle, f));
             pivot.eulerAngles = v3T;
             fTimer += Time.deltaTime;
         }
     }
     
     void OnMouseDown() {
         dragging = true;
         Vector3 v3T = (Vector3)Input.mousePosition - v3Pivot;
         angle = Mathf.Atan2 (v3T.y, v3T.x) * Mathf.Rad2Deg;
     }
     
     void OnMouseDrag() {
         Vector3 v3T = (Vector3)Input.mousePosition - v3Pivot;
         float angleT  = Mathf.Atan2 (v3T.y, v3T.x)  * Mathf.Rad2Deg;
         angleDiff = Mathf.DeltaAngle(angle, angleT);
         pivot.Rotate(new Vector3(0.0f, 0.0f, angleDiff));
         angle = angleT;
     }
     
     void OnMouseUp() {
         
         Vector3 v3T = Camera.main.WorldToScreenPoint(transform.position); 
         v3T = v3T - v3Pivot;
         float angle = Mathf.Atan2 (v3T.y, v3T.x) * Mathf.Rad2Deg;
         
         Debug.Log (angle);
         
         if (angle < 0.0f) 
             angle += 360.0f;
         
         startAngle = angle;
         
         if (angle <= 90.0f) {
             endAngle = angle - 2.0f * angle - 180.0f;
         }
         else if (angle <= 180.0f) {
             endAngle = angle + 2.0f * (180.0f - angle) + 180.0f;
         }
         else if (angle <= 270.0f) {
             endAngle = angle + 2.0f * (270.0f - angle);
         }
         else {
             endAngle = angle - 2.0f * (angle - 270.0f);
         }
         
         dragging = false;
         fTimer = 0.0f;
     }
 }