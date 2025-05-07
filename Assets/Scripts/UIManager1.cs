using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager1 : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI restartText;
    public TextMeshProUGUI lifeText;
    // Start is called before the first frame update
    void Start()
    {
        restartText.gameObject.SetActive(false);
    }

    public void SetRestart(float score,float highscore)
    {
        restartText.gameObject.SetActive(true);
        restartText.text += "\nMAX: "+highscore.ToString()+"\nNOW: " + score.ToString();
    }
    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }
    public void UpdateLife(int score)
    {
        lifeText.text = score.ToString();
    }
}
