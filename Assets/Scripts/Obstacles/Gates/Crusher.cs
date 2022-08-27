using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crusher : BaseGate
{

    public Mesh mesh;
    public Material material;

    public override void toDo(Gem gem)
    {
        if (gem.state == GemState.mud)
        {

            gem.meshFilter.mesh = mesh;

            gem.meshRenderer.material = MaterialPool.Instance.stockMaterials[gem.gemColorIndex];

            gem.gem.SetActive(false);

            PoolManager.Instance.GetPooledObject(3).transform.position = gem.transform.position;

            gem.state = GemState.broken;

        }

    }

}
