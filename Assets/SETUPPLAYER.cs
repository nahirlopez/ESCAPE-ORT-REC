using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SETUPPLAYER : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<raycaster>().LoadReferences();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
