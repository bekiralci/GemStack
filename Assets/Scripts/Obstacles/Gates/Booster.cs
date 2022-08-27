using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : BaseGate
{
    
    public override void toDo(Gem gem)
    {

        if (gem.state != GemState.mud)
        {
            gem.gemColorIndex++;

            ScoreControl.Instance.ChangeScore(1);

            gem.meshRenderer.material = MaterialPool.Instance.stockMaterials[gem.gemColorIndex];

            gem.GrowUp();
        }

    }

}
