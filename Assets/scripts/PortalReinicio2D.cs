using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalReinicio2D : MonoBehaviour
{
    public GameObject Sphere;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D col)

    {
        if (col.gameObject.name == "PortalScreamer")
        {
            Debug.Log("ded");
            Destroy(Sphere);
        }
    
      
            if (col.gameObject.name == "PortalScreamer")
            {

                Debug.Log("Contacto");
                transform.position = new Vector3(-7.57f, -2.49f, 0f);
            }

        }

    }


