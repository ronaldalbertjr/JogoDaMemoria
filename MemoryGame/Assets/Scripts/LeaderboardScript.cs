using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LeaderboardScript : MonoBehaviour
{
    public Text localHighscoreText;
    public Text[] highscoreText;
    public Highscores highscoreManager;
    public Canvas menu;
    public Canvas leaderboard;    
	void Start ()
    {
        for(int i = 0; i < highscoreText.Length; i++)
        {
            highscoreText[i].text = i + 1 + ". ";
        }
        StartCoroutine("RefreshHighscores");
        localHighscoreText.text = "Your Highscore: " + PlayerPrefs.GetInt("Highscore");
	}

    public void OnHighscoresDownloaded(Highscore[] highscoreList)
    {
        for (int i = 0; i < highscoreText.Length; i++)
        {
            highscoreText[i].text = i + 1 + ". ";
            if(highscoreList.Length > i)
            {
                highscoreText[i].text += highscoreList[i].username + " - " + highscoreList[i].score;
            }
        }
    }

	IEnumerator RefreshHighscores()
    {
        while(true)
        {
            highscoreManager.DownloadHighscores();
            yield return new WaitForSeconds(30);
        }  
    }

    public void OnVoltarAoMenuClick()
    {
        leaderboard.enabled = false;
        menu.enabled = true;
    }
}
