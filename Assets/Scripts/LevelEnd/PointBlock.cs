using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using DG.Tweening;
public class PointBlock : MonoBehaviour
{

    public TextMeshPro text;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Hand hand))
        {

            gameObject.transform.DOScaleX(4f, .2f).OnComplete(() =>
            {
                gameObject.transform.DOScaleX(2.2f, .3f);
            });

        }
    }

}
