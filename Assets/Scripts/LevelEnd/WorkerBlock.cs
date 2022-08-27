using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class WorkerBlock : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {

        if (other.TryGetComponent(out Hand hand))
        {

            

        }

    }

}
