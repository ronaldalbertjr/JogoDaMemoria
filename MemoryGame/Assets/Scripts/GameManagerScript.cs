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
    public List<GameObject> clickedCards = new List<GameObject>();
    public Slider life;
    public Text textScore;
    public Highscores Highscore;
    GameObject[] cards;
    GameObject[] cards2;
    GameObject cam;
    float turnTime;
    string username;
    float score;
    int toWin;
    bool notEqui = false;

    void Awake()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
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
        score = life.value * 100;
        textScore.text = "Score: " + score.ToString(); 
        if (clickedCards.Count > 2)
        {
            notEqui = true;
        }
        if(clickedCards.Count == 2 && !notEqui)
        {
            if(clickedCards[0] == clickedCards[1].GetComponent<ButtonScript>().equivalenteImage && clickedCards[0].GetComponent<ButtonScript>().clicked)
            {
                clickedCards.Clear();
                toWin++;
                if(toWin >= 11)
                {
                    Debug.Log("Venceu");
                    score = score > PlayerPrefs.GetInt("Highscore") ? score : PlayerPrefs.GetInt("Highscore");
                    PlayerPrefs.SetInt("Highscore",(int) score);
                    Highscore.AddNewHighscore(PlayerPrefs.GetString("Username"), PlayerPrefs.GetInt("Highscore"));
                }
            }
            else
            {
                notEqui = true;
            }
        }

        if(notEqui)
        {
            life.value -= 0.0005f;
            turnTime += Time.deltaTime;
            if(turnTime >= 0.5)
            {
                foreach(GameObject cardr in clickedCards)
                {
                    cardr.GetComponent<ButtonScript>().unTurn();
                }
            }
            if(turnTime >= 1.2)
            {
                notEqui = false;
                clickedCards.Clear();
                turnTime = 0;
            }
            if(life.value <= 0)
            {
                Debug.Log("Perdeu");
            }
        }
    }

    public void OnEntrarClick()
    {
        PlayerPrefs.SetString("Username", cam.GetComponent<CameraScript>().inputField.text);
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
