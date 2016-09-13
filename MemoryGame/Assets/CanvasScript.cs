using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CanvasScript : MonoBehaviour 
{
    float time;
	void Start () 
    {
	
	}
	
	void Update () 
    {
	    
	}

    public void OnClick(RawImage image)
    {
        image.transform.SetAsLastSibling();
    }
}
