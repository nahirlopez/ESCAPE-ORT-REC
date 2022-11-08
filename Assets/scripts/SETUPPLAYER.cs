using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SETUPPLAYER : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timedelay());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Timedelay()
    {
        yield return new WaitForSeconds(0.2f);
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<raycaster>().LoadReferences();
        GameObject.FindGameObjectWithTag("Player").GetComponent<cambioescenaMINIUJEGO2D>().LoadReferences();
        GameObject.FindGameObjectWithTag("EditorOnly").GetComponent<FPSTRUE>().LoadReferences();
        GameObject.FindGameObjectWithTag("MADERAS").GetComponent<MADERAS>().LoadReferences();

    }
}
