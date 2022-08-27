using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wisher : BaseGate
{
    private void OnTriggerEnter(Collider other)
    {



    }

    public override void toDo(Gem gem)
    {

        if (gem.state != GemState.mud)
        {

            gem.meshRenderer.material = MaterialPool.Instance.shinyMaterials[gem.gemColorIndex];

        }

    }

}
