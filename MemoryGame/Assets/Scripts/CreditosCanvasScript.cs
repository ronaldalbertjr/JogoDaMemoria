using UnityEngine;
using System.Collections;

public class CreditosCanvasScript : MonoBehaviour
{
    public Canvas menu;
    public Canvas cred;
    public void OnVoltarAoMenuClick()
    {
        cred.enabled = false;
        menu.enabled = true;
        menu.gameObject.GetComponent<MenuScript>().disabled = false;
    }
}
