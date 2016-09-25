using UnityEngine;
using System.Collections;

public class Highscores : MonoBehaviour
{
    const string privateCode = "koiY2NQ1G0e0KjP4p8wk8QVVRRNOWzkEylGB8VOnQCKA";
    const string publicCode = "57e808968af6030458196265";
    const string webURL = "http://dreamlo.com/lb/";
    public LeaderboardScript leaderboardHighscores;
    public Highscore[] highscoresList;
    void Awake()
    {
    }

    {
        StartCoroutine(UploadNewHighscore(username, score));
    }
    
    {
        WWW www = new WWW(webURL + privateCode + "/add/" + WWW.EscapeURL(username) + "/" + score);
        yield return www;

        if(string.IsNullOrEmpty(www.error))
        {
            Debug.Log("Upload Sucessful");
        }
        else
        {
            Debug.Log("Error Uploading: " + www.error);
        }
    }
    public void DownloadHighscores()
    {
        StartCoroutine("DownloadHighscoresFromDatabase");
    }
    IEnumerator DownloadHighscoresFromDatabase()
    {
        WWW www = new WWW(webURL + publicCode + "/pipe/");
        yield return www;

        if (string.IsNullOrEmpty(www.error))
        {
            FormatHighscores(www.text);
        }
        else
        {
            Debug.Log("Error Downloading: " + www.error);
        }
    }

    void FormatHighscores(string textStream)
    {
        string[] entries = textStream.Split(new char[] { '\n' }, System.StringSplitOptions.RemoveEmptyEntries);
        highscoresList = new Highscore[entries.Length]; 
        for(int i = 0; i < entries.Length; i++)
        {
            string[] entryInfo = entries[i].Split(new char[]{'|'});
            string username = entryInfo[0];
            highscoresList[i] = new Highscore(username, score);
        }
    }
}

public struct Highscore
{
    public string username;

    {
        username = _username;
        score = _score;
    }
}

