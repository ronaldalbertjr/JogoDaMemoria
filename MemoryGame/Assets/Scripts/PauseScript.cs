using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour
{
	public void OnVoltarAoJogoClick()
    {
        Time.timeScale = 1;
        this.GetComponent<Canvas>().enabled = false;
    }
    public void OnvoltarAoMenuClick()
    {
        Time.timeScale = 1;
        Application.LoadLevel("Scene");
    }
    public void OnSairClick()
    {
        Application.Quit();
    }
}
