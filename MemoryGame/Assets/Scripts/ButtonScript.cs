using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour 
{
    public Sprite sp;
    public GameObject equivalenteImage;
    public bool clicked = false;

    RawImage ima;

    float time;
    bool bothClicked = false;
	
	void Update () 
    {
	    if(clicked)
        {
            this.transform.rotation = Quaternion.Lerp(this.transform.rotation, Quaternion.Euler(0f, 180f, 0f), 0.1f);
            if (this.transform.eulerAngles.y >= 90f)
            {
                this.GetComponent<Image>().sprite = sp;         
            }
            if(bothClicked)
            {
                this.GetComponent<Image>().fillAmount -= 0.01f;
                equivalenteImage.GetComponent<Image>().fillAmount -= 0.01f;
            }
        }
        if(this.GetComponent<Image>().fillAmount <= 0)
        {
            Destroy(this.gameObject);
            Destroy(equivalenteImage);
        }
    }

    public void OnClick()
    {
        clicked = true;
        if(equivalenteImage.GetComponent<ButtonScript>().clicked)
        {
            bothClicked = true;
        }
    }
}
