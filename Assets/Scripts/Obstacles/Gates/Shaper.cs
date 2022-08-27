using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shaper : BaseGate
{
    public Mesh mesh;

    public override void toDo(Gem gem)
    {

        if (gem.state == GemState.broken)
        {

            gem.meshFilter.mesh = mesh;

            gem.state = GemState.gem;

            PoolManager.Instance.GetPooledObject(gem.gemColorIndex).transform.position = gem.transform.position;

        }

    }

}
