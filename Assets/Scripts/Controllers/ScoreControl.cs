using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreControl : MonoBehaviour
{
    #region --SINGLETON--

    private static ScoreControl instance;

    public static ScoreControl Instance { get { return instance; } }

    private void OnEnable()
    {
        instance = this;
    }

    #endregion


    public int score;
    public TextMeshPro scoreText;

    public void ChangeScore(int value)
    {

        score += value;
        scoreText.text = "$ " + score.ToString();

    }

}
