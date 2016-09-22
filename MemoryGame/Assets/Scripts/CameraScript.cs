using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour 
{
    public bool movement = false;
    public Transform camPos1;
    public Transform camPos2;
	void Update () 
    {
        if(movement)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, camPos2.position, 10f);
            this.transform.eulerAngles = Vector3.MoveTowards(this.transform.eulerAngles, camPos2.eulerAngles, 1f); 
        }	
        else
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, camPos1.position, 50f);
        }
	}
}
