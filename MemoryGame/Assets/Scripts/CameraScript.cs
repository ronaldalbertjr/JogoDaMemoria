using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour 
{
    public bool movement = false;
    public Transform camPos;
	void Update () 
    {
        if(movement)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, camPos.position, 1000);
            this.transform.eulerAngles = Vector3.MoveTowards(this.transform.eulerAngles, camPos.eulerAngles, 10); 
        }	
	}
}
