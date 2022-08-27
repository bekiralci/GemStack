using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Gem : MonoBehaviour
{
    public GemState state;
    public MeshFilter meshFilter;
    public MeshRenderer meshRenderer;

    public GameObject gem;

    public int gemColorIndex;

    public bool isCollectable = true;

    private void Start()
    {
        gemColorIndex = 0;

        meshFilter = GetComponent<MeshFilter>();
        meshRenderer = GetComponent<MeshRenderer>();

        state = GemState.mud;
    }

    public void GrowUp()
    {
        Vector3 defaultScale = Vector3.one;

        transform.DOScale(defaultScale * 1.4f, .2f).OnComplete(() =>
        {
            transform.DOScale(Vector3.one, .2f);
        });
    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.TryGetComponent(out IGate gate))
        {
            gate.toDo(this);
        }

    }

}
