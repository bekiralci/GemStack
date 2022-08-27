using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public enum GemState
{
    mud, broken, gem
}

public class GemManager : MonoBehaviour
{

    #region --SINGLETON--

    private static GemManager instance;

    public static GemManager Instance
    {
        get
        {
            if (instance == null)
                instance = new GameObject("GemManager").AddComponent<GemManager>();

            return instance;

        }
    }
    private void OnEnable()
    {
        instance = this;
    }

    #endregion


    public List<Gem> GemList = new();

    public bool isMove = true;

    private void Start()
    {

    }

    private void Update()
    {
        if (isMove)
        {
            GemMovement();
        }
    }   

    void GemMovement()
    {
        for (int i = 1; i < GemList.Count; i++)
        {
            GemList[i].transform.DOMoveX(GemList[i - 1].transform.position.x, .2f);
        }
    }

}
