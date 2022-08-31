using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linterna : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Light flashlight;
   
    //public GameObject camara;

    // Update is called once per frame
    void Update()
    {
        //transform.rotation = camara.transform.rotation;

        if (Input.GetKeyDown(KeyCode.F))
        {

            flashlight.enabled = !flashlight.enabled;
        }
    }
}
