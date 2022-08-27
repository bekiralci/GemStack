using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RingBox : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {

        if (other.TryGetComponent(out Gem gem))
        {
            GemManager.Instance.isMove = false;
            //

            GetComponent<BoxCollider>().enabled = false;

            Vector3 vector3 = new Vector3(transform.position.x, 1, transform.position.z);

            gem.transform.SetParent(null);
            GemManager.Instance.GemList.Remove(gem);
            gem.transform.DOMove(vector3, .5f);

            //
            GemManager.Instance.isMove = true;

        }

    }

}
