using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class juego2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OntriggerEnter (Collider col)
    {
        if(col.gameObject.tag == "DEATH")
        {
            transform.position = new Vector3(-302.7511f, 285917f, -2743.33f);
        }
    }
}
