using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TEST : MonoBehaviour
{

    public GameObject pointBlock;
    public TextMeshPro pointText;
    public int point = 15;

    public Material acikmavi;
    public Material lacivert;

    bool ifacik;
    public bool ilkmi;

    [ContextMenu("TESTET")]
    private void TESTET()
    {
        InsaEt();
    }

    void InsaEt()
    {
        for (int i = 0; i < 40; i++)
        {



            Vector3 vector3 = new(0, 1, 0);

            GameObject gameObject = Instantiate(pointBlock);

            gameObject.transform.parent = transform;
            pointText = gameObject.GetComponentInChildren<TextMeshPro>();

            gameObject.transform.position = gameObject.transform.localScale.y * i * vector3;

            //if (ilkmi)
            //{
            //    pointText.text = "WORKER";
            //    ilkmi = false;
            //}
            //else
            //{
            //    pointText.text = point.ToString();
            //    point += 15;
            //}

            //if (ifacik)
            //{
            //    gameObject.GetComponent<MeshRenderer>().material = acikmavi;
            //    ifacik = false;
            //}
            //else
            //{
            //    gameObject.GetComponent<MeshRenderer>().material = lacivert;
            //    ifacik = true;
            //}

        }
    }

}
