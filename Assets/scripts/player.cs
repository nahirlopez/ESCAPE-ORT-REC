using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    // Start is called before the first frame update


   public bool llavebl;
    public GameObject llave;
    public GameObject puerta;
    public int checkpoint;
    //int cpconfirmed;
    public GameObject inventario;
    public GameObject invllave;
    bool inv;
    //public GameObject compu;
   
   
    void Start()
    {
        //hasJump = true;
        llavebl = false;

        //rb = GetComponent<Rigidbody>();
        checkpoint = 0;
        //cpconfirmed = 0;                                    

        inv = false;

        


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            inventario.SetActive(inv);
            inv = !inv;

        }

        


        //if (checkpoint == 0 && cpconfirmed == 0)
        //{
        //    transform.position = new Vector3(47.04f, 6.695f, 0f);
        //    cpconfirmed++;
        //}
        //if (checkpoint == 1 && cpconfirmed == 1)
        //{
        //    transform.position = new Vector3(47.04f, 6.695f, 0f);
        //}

        //if (cercallave )
        //{
        //    tecla.text = "'E' para interactuar";
        //    if (Input.GetKeyDown(KeyCode.E))
        //    {
        //        tecla.text = "";
        //        cercallave = false;
        //        llave.SetActive(false);
        //        llavebl = true;
        //        invllave.SetActive(true);
        //    }
        //}
        //if (cercapuerta && llavebl)
        //{
        //    tecla.text = "'E' para interactuar";
        //    if (Input.GetKeyDown(KeyCode.E))
        //    {
        //        tecla.text = "";
        //        puerta.SetActive(false);
        //       invllave.SetActive(false);
        //    }
        //}

        //NoCerca(cercapuerta);
        //NoCerca(cercallave);


    }
    //void NoCerca(bool a)
    //{
    //    if (a == false)
    //    {
    //        tecla.text = "";
    //    }
    //}

       
        
    void OnCollisionEnter(Collision col)
    {
      
       
        if (col.gameObject.name == "paso" )
        {
            puerta.SetActive(true);
            
        }

        if (col.gameObject.name == "bienvenidos" && checkpoint == 0)
        {
            SceneManager.LoadScene("ranzo");
            checkpoint++;
        }






        
    }

    //void OnTriggerEnter(Collider col)
    //{
    //    if (col.gameObject.name == "llave")
    //    {
    //        cercallave = true;
    //    }
    //    if (col.gameObject.name == "puerta")
    //    {
    //        cercapuerta = true;
    //    }

    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject.name == "llave")
    //    {
    //        cercallave = false;
    //    }
    //    if (other.gameObject.name == "puerta")
    //    {
    //        cercapuerta = false;
    //    }
    //}

}
