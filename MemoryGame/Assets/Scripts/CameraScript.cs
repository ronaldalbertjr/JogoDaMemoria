using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CameraScript : MonoBehaviour 
{
    public Transform camPos1;
    public Transform camPos2;
    public Canvas menu;
    public Image bg;
    public bool movement = false;
    bool filling = false;
    void Start()
    {
        menu.enabled = false;
        bg.fillAmount = 0;
    }
	void Update () 
    {
        if(filling && bg.fillAmount < 1)
        {
            bg.fillAmount += 0.01f;
        }
        if(movement)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, camPos2.position, 10f);
            this.transform.eulerAngles = Vector3.MoveTowards(this.transform.eulerAngles, camPos2.eulerAngles, 1f); 
        }	
        else
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, camPos1.position, 50f);
        }
        if(this.transform.position == camPos1.position)
        {
            menu.enabled = true;
            filling = true;
        }
	}
}
