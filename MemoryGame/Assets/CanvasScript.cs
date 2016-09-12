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

    public void OnClick(Button button)
    {
        time += Time.deltaTime;
        if (time > 51)
        {
            button.transform.eulerAngles = new Vector3(0f, 180f);
            button.transform.localScale = new Vector3(1.5f, 1.5f);
            button.GetComponent<Animator>().enabled = false;
        }
    }
}
