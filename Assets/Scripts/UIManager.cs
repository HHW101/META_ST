using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI talkText;
    private static UIManager uIManager;
    public static UIManager Instance {  get { return uIManager; } }
    // Start is called before the first frame update
    private void Awake()
    {
        uIManager = this;
    }
    public void OpenBoard()
    {
        if(scoreText.gameObject.activeSelf)
        {
            scoreText.gameObject.SetActive(false);
            return;
        }
        scoreText.gameObject.SetActive(true);
        int highscore = PlayerPrefs.GetInt("HighScoreB", 0);
        scoreText.text = "Block MAX: " + highscore.ToString();

    }
    public void Opentalk(string a)
    {
        if (scoreText.gameObject.activeSelf)
        {
            talkText.gameObject.SetActive(false);
            return;
        }
        talkText.gameObject.SetActive(true);
        talkText.text = a;

    }
    public void closetalk()
    {
        talkText.gameObject.SetActive(false);
    }
    public void closeBoard()
    {
        scoreText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
