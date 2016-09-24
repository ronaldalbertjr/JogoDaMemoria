using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour 
{
    public GameObject cam;
    public Text highscore;
    void Start()
    {
        highscore.text = PlayerPrefs.GetFloat("Highscore").ToString();
    }
    public void OnPlay()
    {
        cam.GetComponent<CameraScript>().movement = true;
    }
}
