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
            while(i < ivo.GetComponent<DialogueName>().Dialogo.Length)
            {
                ivo.GetComponent<DialogueName>().Dialogo[i] = "";
            }

            ivo.GetComponent<DialogueName>().Dialogo[0] = "Ivo: ¿Y? ¿Cómo fue eso? ";
            ivo.GetComponent<DialogueName>().Dialogo[1] = "Ivo: Espero que no te hayas confundido de portal...";
            ivo.GetComponent<DialogueName>().Dialogo[2] = "Ivo: Si ves otra madera en la pecera, ¡Busca a Jero!";
        }
    }

    public void LoadReferences()
    {
        ivo = GameObject.Find("FANTASMA IVO");
        jero = GameObject.Find("FANTASMA JERO");
        ranzo = GameObject.Find("FANTASMA RANZO");
    }
}
