using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SETUPPLAYER : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<raycaster>().LoadReferences();
        GameObject.FindGameObjectWithTag("Player").GetComponent<cambioescenaMINIUJEGO2D>().LoadReferences();
        GameObject.FindGameObjectWithTag("EditorOnly").GetComponent<FPSTRUE>().LoadReferences();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
