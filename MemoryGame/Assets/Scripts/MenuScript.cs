using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour 
{
    public GameObject cam;

    public void OnPlay()
    {
        cam.GetComponent<CameraScript>().movement = true;
    }
}
