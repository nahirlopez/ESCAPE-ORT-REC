using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class juego2 : MonoBehaviour
{
    public GameObject fps;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
     void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == "DEATH")
        {
            fps.transform.position = new Vector3(-298.6775f, 15.10432f, -2751.258f);
        }
    }

    

}
  