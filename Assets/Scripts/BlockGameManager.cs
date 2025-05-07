using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlockGameManager : MonoBehaviour
{
    // Start is called before the first frame update
    static BlockGameManager blockGameManager;
    public static BlockGameManager Instance { get { return blockGameManager; } }
    private int currentScore = 0;
    bool isEnd = false;
    UIManager1 uIManager;
    private void Awake()
    {
        blockGameManager = this;
        uIManager=FindObjectOfType<UIManager1>();
    }
    public void GameOver()
    {
        isEnd = true;
        int highS= PlayerPrefs.GetInt("HighScoreB", 0);
        highS= Mathf.Max(highS, currentScore);
        PlayerPrefs.SetInt("HighScoreB",highS);
        PlayerPrefs.Save();
        uIManager.SetRestart(currentScore,highS);
    }
    void OnPush()
    {
        if (isEnd)
            SceneManager.LoadScene("MainScene");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Demaged(int life)
    {
        uIManager.UpdateLife(life);
    }
    public void AddScore(int score)
    {
        currentScore += score;
        Debug.Log(currentScore);
        uIManager.UpdateScore(currentScore);

    }
}
