using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialPool : MonoBehaviour
{

    #region //SINGLETON\\

    private static MaterialPool instance;
    public static MaterialPool Instance { get { return instance; } }

    private void OnEnable()
    {
        instance = this;
    }

    #endregion

    public List<Material> stockMaterials = new();
    public List<Material> shinyMaterials = new();

}
