using UnityEngine;
using System.Collections;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour 
{
    List<GameObject> clickedCards = new List<GameObject>();

    float turnTime;
    bool notEqui = false;

	void Update () 
    {
        if(clickedCards.Count >= 2)
        {
            if(clickedCards[0] == clickedCards[1].GetComponent<ButtonScript>().equivalenteImage && clickedCards[0].GetComponent<ButtonScript>().clicked)
            {
                Debug.Log("YEAHH");
            }
            else
            {
                notEqui = true;
                Debug.Log("NOOOOOO");
            }
        }

        if(notEqui)
        {
            turnTime += Time.deltaTime;
            if(turnTime >= 0.5)
            {
                clickedCards[0].GetComponent<ButtonScript>().unTurn();
                clickedCards[1].GetComponent<ButtonScript>().unTurn();
            }
            if(turnTime >= 1.5)
            {
                notEqui = false;
                clickedCards.Clear();
                turnTime = 0;
            }
        }
    }

    public void click(GameObject card)
    {
        clickedCards.Add(card);
    }
}
