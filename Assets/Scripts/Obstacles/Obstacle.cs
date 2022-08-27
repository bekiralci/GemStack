using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Obstacle : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Gem gem))
        {
            Transform parent = gem.transform.parent.parent;
            parent.DOLocalMoveZ(parent.position.z - 1.5f, 1);

            GameObject go = GemManager.Instance.GemList[^1].gameObject;
            GemManager.Instance.GemList.Remove(GemManager.Instance.GemList[^1]);
            Destroy(go);

        }
    }

}
