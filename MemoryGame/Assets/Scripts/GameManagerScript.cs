using UnityEngine;
using System.Collections;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour 
{
    GameObject[] cards;
    GameObject[] cards2;
    List<GameObject> clickedCards = new List<GameObject>();
	void Start ()
    {
        cards = GameObject.FindGameObjectsWithTag("Cards");
        cards2 = GameObject.FindGameObjectsWithTag("Cards2");
	}
	void Update () 
    {
	    foreach(GameObject card in cards)
        {
            if(card.GetComponent<ButtonScript>().clicked)
            {
                clickedCards.Add(card);
            }
        }
        if(clickedCards.Count >= 2)
        {
            Debug.Log(clickedCards[0].name);
            Debug.Log(clickedCards[1].name);
            if(clickedCards[0].GetComponent<Image>().sprite == clickedCards[1].GetComponent<Image>().sprite)
            {
                Debug.Log("Yeahhh");
            }
        }
	}
}
