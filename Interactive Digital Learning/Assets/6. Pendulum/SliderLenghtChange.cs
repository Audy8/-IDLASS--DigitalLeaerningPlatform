using UnityEngine;
using System.Collections;

public class SliderLenghtChange : MonoBehaviour {
Vector3 temp;
void Update()
{

}
public void OnValueChange(float value)
{
temp=transform.localScale;
temp.y=value;
transform.localScale=temp;
}
}