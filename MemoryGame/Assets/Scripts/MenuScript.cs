using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour 
{
    public GameObject cam;
    public Canvas leaderboardCanvas;
    public Canvas menu;
    public bool disabled;
    void Awake()
    {
        leaderboardCanvas.enabled = false;
    }
    void Update()
    {
        if(disabled)
        {
            DisabablingCanvas();
        }
    }
    public void OnJogarClick()
    {
        cam.GetComponent<CameraScript>().enterNameAppear = true;
    }
    public void OnLeaderboardClick()
    {
        leaderboardCanvas.enabled = true;
        disabled = true;
    }
    public void OnCreditosClick()
    {
        Debug.Log("Creditos Cena");
    }
    public void OnSairClick()
    {
        Application.Quit();
    }
    void DisabablingCanvas()
    {
        menu.GetComponentInChildren<Image>().fillAmount -= 0.01f;
        if (menu.GetComponentInChildren<Image>().fillAmount <= 0f)
        {
            menu.enabled = false;
        }
    }
}
