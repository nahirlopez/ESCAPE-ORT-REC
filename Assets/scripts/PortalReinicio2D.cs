using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalReinicio2D : MonoBehaviour
{

    public GameObject screamer;
    
    public AudioClip SCREAM;
    public AudioSource SOURCE;



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
            
        }
    
      
            if (col.gameObject.name == "PortalScreamer")
            {

                Debug.Log("Contacto");
                transform.position = new Vector3(-7.57f, -2.49f, 0f);
             screamer.SetActive(true);
              


             StartCoroutine(Timedelay());


            }


        }
    IEnumerator Timedelay()
    {
        yield return new WaitForSeconds(5);
        screamer.SetActive(false);

    }
    }



