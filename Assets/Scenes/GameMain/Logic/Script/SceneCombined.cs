using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneCombined : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
        {
        Application.LoadLevelAdditive("UI");
        Application.LoadLevelAdditive("MAP01");
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
