using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Cashes : MonoBehaviour
{

    public Transform handPrefab;


    private void OnTriggerEnter(Collider other)
    {

        if (other.TryGetComponent(out Hand hand))
        {

            hand.GetComponentInParent<PlayerMovement>().canMove = false;
            Sequence mySequence = DOTween.Sequence();

            transform.SetParent(hand.transform);
            mySequence.Join(handPrefab.transform.DOLocalMove(new Vector3(0, 0, handPrefab.localPosition.z), .4f));
            mySequence.Join(handPrefab.transform.DORotate(new Vector3(0, 0, 180), .7f));
            mySequence.OnComplete(() =>
            {
                hand.transform.DOMoveY(14f, 1f).OnComplete(() =>
                {
                    GameManager.Instance.LevelWinner();
                });
            });



        }

    }

}

