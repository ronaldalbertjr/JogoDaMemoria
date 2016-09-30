using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CameraScript : MonoBehaviour 
{
    public Canvas pause;
    public Transform camPos1;
    public Transform camPos2;
    public Canvas menu;
    public Canvas enterName;
    public InputField inputField;
    public Image bg;
    public bool movement = false;
    public bool enterNameAppear = false;
    bool filling = false;
    void Start()
    {
        pause.enabled = false;
        menu.gameObject.GetComponent<AudioSource>().Pause();
        menu.enabled = false;
        enterName.enabled = false;
        bg.fillAmount = 0;
    }
	void Update () 
    {
        if(filling && bg.fillAmount < 1)
        {
            bg.fillAmount += 0.01f;
        }
        if(enterNameAppear)
        {
            menu.gameObject.GetComponent<AudioSource>().Pause();
            if (!PlayerPrefs.HasKey("Username"))
            {
                enterName.enabled = true;
            }
            else if (PlayerPrefs.HasKey("Username"))
            {
                enterName.enabled = false;
                this.transform.position = Vector3.MoveTowards(this.transform.position, camPos2.position, 10f);
                this.transform.eulerAngles = Vector3.MoveTowards(this.transform.eulerAngles, camPos2.eulerAngles, 1f);
            }        
        }	
        else
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, camPos1.position, 50f);
        }
        if(this.transform.position == camPos1.position)
        {
            menu.gameObject.GetComponent<AudioSource>().UnPause();
            menu.enabled = true;
            filling = true;
        }
        if(Input.GetKey(KeyCode.Escape) && PlayerPrefs.HasKey("Username") && enterNameAppear)
        {
            pause.enabled = true;
            Time.timeScale = 0;
        }
	}
}
