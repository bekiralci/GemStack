using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private static GameManager instance;

    public static GameManager Instance { get { return instance; } }

    private void OnEnable()
    {
        instance = this;
    }


    bool gameEnd;

    public void LevelWinner()
    {
        if (gameEnd == false)
        {
            gameEnd = true;

            StartCoroutine(waitForWinner());

        }
    }

    IEnumerator waitForWinner()
    {
        yield return new WaitForSeconds(1.5f);
        LevelManager.Instance.SceneWinControl();
        LevelManager.Instance.LevelDone();
    }
}
