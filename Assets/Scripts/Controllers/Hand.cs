using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Hand : MonoBehaviour
{



    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Gem gem) && gem.isCollectable)
        {

            GemManager.Instance.GemList.Add(gem);

            gem.transform.SetParent(transform);
            gem.transform.localPosition = new Vector3(0, -.5f, transform.localScale.z * GemManager.Instance.GemList.Count + 1);

            StartCoroutine(GrowUp(GemManager.Instance.GemList));

            ScoreControl.Instance.ChangeScore(10);

            gem.isCollectable = false;
        }
    }

    IEnumerator GrowUp(List<Gem> list)
    {

        for (int i = list.Count - 1; i >= 0; i--)
        {
        Vector3 defaultScale = Vector3.one;

            list[i].GrowUp();

            yield return new WaitForSeconds(.2f);
        }

    }

}
