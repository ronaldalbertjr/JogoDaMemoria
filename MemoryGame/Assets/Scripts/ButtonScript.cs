using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour 
{
    public Sprite sp;
    public Sprite sp2;
    public bool clicked = false;
    public GameObject equivalenteImage;
    GameObject[] cards;
    GameObject[] cards2;
    RawImage ima;
    GameObject gameManager;
    float time;
    bool bothClicked = false;
	
    void Awake()
    {
        gameManager = GameObject.FindGameObjectWithTag("Manager");
        cards = GameObject.FindGameObjectsWithTag("Cards");
        cards2 = GameObject.FindGameObjectsWithTag("Cards2");
    }

    void Start()
    {
        if (this.gameObject.tag == "Cards")
        {
            foreach(GameObject card in cards2)
            {
                if(card.GetComponent<ButtonScript>().sp == this.sp)
                {
                    equivalenteImage = card;
                }
            }
        }
        else if (this.gameObject.tag == "Cards2")
        {
            foreach (GameObject card in cards)
            {
                if (card.GetComponent<ButtonScript>().sp == this.sp)
                {
                    equivalenteImage = card;
                }
            }
        }
    }

	void Update () 
    {
	    if(clicked)
        {
            this.transform.localRotation = Quaternion.Lerp(this.transform.localRotation, Quaternion.Euler(0f, 180f, 0f), 0.1f);
            if (this.transform.localEulerAngles.y >= 90f)
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
        gameManager.GetComponent<GameManagerScript>().click(this.gameObject);
        if(equivalenteImage.GetComponent<ButtonScript>().clicked)
        {
            bothClicked = true;
        }
    }

    public void unTurn()
    {
        clicked = false;
        this.transform.localRotation = Quaternion.Lerp(this.transform.localRotation, Quaternion.Euler(0f, 0f, 0f), 0.1f);
        if (this.transform.localEulerAngles.y >= 270f)
        {
            this.GetComponent<Image>().sprite = sp2;
        }
    }
}
