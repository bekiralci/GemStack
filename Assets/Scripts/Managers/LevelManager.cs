using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    #region --SINGLETON--

    private static LevelManager instance;

    public static LevelManager Instance { get { return instance; } }

    private void OnEnable()
    {
        instance = this;
    }

    #endregion

    bool OnGameWin;
    GameManager gm;
    [SerializeField]
    private GameObject Panel, StartButton, NextButton, RetryButton;
    private void Start()
    {
        Panel.SetActive(false);
        StartButton.SetActive(false);
        NextButton.SetActive(false);
        RetryButton.SetActive(false);
        gm = GetComponent<GameManager>();
    }
    public void LevelDone()
    {
        RetryButton.SetActive(false);
        Panel.SetActive(true);
        StartButton.SetActive(false);
        NextButton.SetActive(true);

        SwipeController.Instance.enabled = false;
    }
    public void StartButtonFunc()
    {
        Debug.Log("start");
        Panel.SetActive(false);
        StartButton.SetActive(false);
        NextButton.SetActive(false);
        RetryButton.SetActive(false);
    }
    public void OnFail()
    {
        Panel.SetActive(true);
        StartButton.SetActive(false);
        NextButton.SetActive(false);
        RetryButton.SetActive(true);

    }
    public void RetryButtonProgress()
    {
        NextScene();
    }
    public void NextButtonFunc()
    {
        NextScene();
        SwipeController.Instance.enabled = true;

    }
    public void NextScene()
    {
        SceneManager.LoadScene(0);
    }
    public void SceneWinControl()
    {
        int temp;
        temp = PlayerPrefs.GetInt("CurrentLevel");
        temp++;
        PlayerPrefs.SetInt("CurrentLevel", temp);
    }

}
