using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    #region --SINGLETON--

    private static PlayerMovement instance;

    public static PlayerMovement Instance { get { return instance; } }

    private void OnEnable()
    {
        instance = this;
    }
    #endregion


    public int _speed;
    public bool canMove = true;

    void Update()
    {

        if (canMove)
            transform.position += _speed * Time.deltaTime * transform.forward;

    }
}
