using UnityEngine;
using System.Collections;

public class CandidatosCanvasScript : MonoBehaviour {

    public Canvas cand;
    public Canvas menu;

	public void OnVoltarAoMenuClick()
    {
        cand.enabled = false;
        menu.enabled = true;
        menu.gameObject.GetComponent<MenuScript>().disabled = false;
    }
}
