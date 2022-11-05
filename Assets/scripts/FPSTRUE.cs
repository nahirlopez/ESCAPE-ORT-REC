using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSTRUE : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject fps;
    public InventorySO inventario;
    public GameObject ivo;
    public GameObject jero;
    public GameObject ranzo;

    
    void Start()
    {
        inventario.HasBronzeKey = false;
        inventario.win = false;
        inventario.madera1 = false;
        inventario.madera2 = false;
        inventario.HasGoldenKey = false;

       
    }

    // Update is called once per frame
    void Update()
    {
        if (inventario.win == true)
        {
            fps.SetActive(true);

            int i = 0;
            while (i < ivo.GetComponent<DialogueName>().Dialogo.Length)
            {
                ivo.GetComponent<DialogueName>().Dialogo[i] = "";
                i++;
            }

            ivo.GetComponent<DialogueName>().Dialogo[0] = "Ivo: ¿Y? ¿Cómo fue eso? ";
            ivo.GetComponent<DialogueName>().Dialogo[1] = "Ivo: Espero que no te hayas confundido de portal...";
            ivo.GetComponent<DialogueName>().Dialogo[2] = "Ivo: Si ves otra madera en la pecera, ¡Busca a Jero!";
        }

        if (inventario.madera2 == true)
        {  int i = 0;
            while (i < jero.GetComponent<DialogueName>().Dialogo.Length)
            {
                jero.GetComponent<DialogueName>().Dialogo[i] = "";
                i++;
            }
            jero.GetComponent<DialogueName>().Dialogo[0] = "Jero: Oh.. se te hizo fácil. ";
            jero.GetComponent<DialogueName>().Dialogo[1] = "Jero: Intenta agarrar la llave y ve a hablar con Ranzo";
            
        }

        if (inventario.HasGoldenKey == true)
        {
            int i = 0;
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

    public void LoadReferences()
    {
        ivo = GameObject.Find("FANTASMA IVO");
        jero = GameObject.Find("FANTASMA JERO");
        ranzo = GameObject.Find("FANTASMA RANZO");
    }
}
