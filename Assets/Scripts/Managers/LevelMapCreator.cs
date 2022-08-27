using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMapCreator : MonoBehaviour
{
    public LevelSOTemplate mapObjects;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("CurrentLevel"))
        {
            int tmpLevelCount = PlayerPrefs.GetInt("CurrentLevel");
            
            if (tmpLevelCount < mapObjects.levelPrefabs.Count)
            {
                Instantiate(mapObjects.levelPrefabs[PlayerPrefs.GetInt("CurrentLevel")]);
            }
            else
            {
                Instantiate(mapObjects.levelPrefabs[0]);
                PlayerPrefs.SetInt("CurrentLevel", 0);
            }
        }
        else
        {
            PlayerPrefs.SetInt("CurrentLevel", 0);
            Instantiate(mapObjects.levelPrefabs[0]);
        }

    } // Awake()

} // class
