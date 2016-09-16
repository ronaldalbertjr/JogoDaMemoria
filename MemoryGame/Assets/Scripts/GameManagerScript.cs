using UnityEngine;
using System.Collections;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour 
{

    public Sprite[] sps;
    List<GameObject> clickedCards = new List<GameObject>();
    GameObject[] cards;
    GameObject[] cards2;
    float turnTime;
    bool notEqui = false;

    void Start()
    {
        cards = GameObject.FindGameObjectsWithTag("Cards");
        cards2 = GameObject.FindGameObjectsWithTag("Cards2");
        Shuffle(sps);
        for(int i = 0; i < sps.Length; i++)
        {
            cards[i].GetComponent<ButtonScript>().sp = sps[i];
            cards2[i].GetComponent<ButtonScript>().sp = sps[i];
        }
    }

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
    
    void Shuffle(Sprite[] sprites)
    {

        System.Random r = new System.Random();

        for(int i = 0; i < sprites.Length; i++)
        {
            int idx = r.Next(0, sprites.Length);

            Sprite tmp = sprites[i];
            sprites[i] = sprites[idx];
            sprites[idx] = tmp;
        }
    }
}
