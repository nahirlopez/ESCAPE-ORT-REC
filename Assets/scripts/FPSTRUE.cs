﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FPSTRUE : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject fps;
    public InventorySO inventario;
    public GameObject ivo;
    public GameObject jero;
    public GameObject ranzo;
    public GameObject portalfinal;
    public GameObject portalmj1;


    void Start()
    {
        //inventario.HasBronzeKey = false;
        //inventario.win = false;
        //inventario.madera1 = false;
        //inventario.madera2 = false;
        //inventario.HasGoldenKey = false;
        //inventario.start = false;
        LoadReferences();
        portalfinal.SetActive(false);

        if (inventario.win == true)
        {

            fps.transform.position = new Vector3(516.6133f, 156.1673f, -492.4995f);
            fps.transform.eulerAngles = new Vector3(0, 66.36301f, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {


        if (inventario.win == true)
        {
            portalmj1.SetActive(false);

            if (ivo)
            {
                int i = 0;
                while (i < ivo.GetComponent<DialogueName>().Dialogo.Length)
                {
                    ivo.GetComponent<DialogueName>().Dialogo[i] = "";
                    i++;
                }

                ivo.GetComponent<DialogueName>().Dialogo[0] = "Ivo: ¿Y? ¿Cómo fue eso? ";
                ivo.GetComponent<DialogueName>().Dialogo[1] = "Ivo: Espero que no te hayas confundido de portal...";
                ivo.GetComponent<DialogueName>().Dialogo[2] = "Ivo: Si ves otra madera en la pecera, ¡Busca a Jero pasando por la puerta detrás mio!";
            }
        }

        if (inventario.madera2 == true)
        {
            int i = 0;
            if (jero)
            {
                while (i < jero.GetComponent<DialogueName>().Dialogo.Length)
                {
                    jero.GetComponent<DialogueName>().Dialogo[i] = "";
                    i++;
                }
                jero.GetComponent<DialogueName>().Dialogo[0] = "Jero: Oh.. se te hizo fácil. ";
                jero.GetComponent<DialogueName>().Dialogo[1] = "Jero: Intenta agarrar la llave dorada y ve a hablar con Ranzo, en donde comenzaste.";
            }
        }

        if (inventario.HasGoldenKey == true)
        {
            int i = 0;
            portalfinal.SetActive(true);
            if (ranzo)
            {
                while (i < ranzo.GetComponent<DialogueName>().Dialogo.Length)
                {
                    ranzo.GetComponent<DialogueName>().Dialogo[i] = "";
                    i++;
                }
                ranzo.GetComponent<DialogueName>().Dialogo[0] = "Ranzo: No puedo creerlo, ¡Lo lograste!";
                ranzo.GetComponent<DialogueName>().Dialogo[1] = "Ranzo: Ve a la salida de acá a mi derecha.";
                ranzo.GetComponent<DialogueName>().Dialogo[2] = "Ranzo: ¡ESCAPEMOS!";
            }
        }
        if (inventario.start == true)
        {
            
            inventario.start = false;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            inventario.HasBronzeKey = false;
            inventario.win = false;
            inventario.madera1 = false;
            inventario.madera2 = false;
            inventario.HasGoldenKey = false;
            inventario.start = false;

            fps.transform.position = new Vector3(530.7f, 159.91f, -659.79f);
            fps.transform.eulerAngles = new Vector3(0, 50.163f, 0);
            SceneManager.LoadScene("COMIENZO");
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            
            StartCoroutine(Timedelay());
            //fps.SetActive(false);

        }
    }

    IEnumerator Timedelay()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("MENÚ");

    }
    public void LoadReferences()
    {
       
        ivo = GameObject.Find("FANTASMA IVO");
        jero = GameObject.Find("FANTASMA JERO");
        ranzo = GameObject.Find("FANTASMA RANZO");
    }

}
