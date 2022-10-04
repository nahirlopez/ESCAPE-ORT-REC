using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogoRanzo : MonoBehaviour
{
    [SerializeField] GameObject dialogoUI;
    [SerializeField] TextMeshProUGUI TextoDelDialogo;
    [SerializeField] string[] TextoRanzo = new string[4];
    [SerializeField] int IncDialogo = 0;


    // Start is called before the first frame update
    void Start()
    {
        dialogoUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ranzo"))
        {
            //TextoDelDialogo.text = "Ranzo: Ayudame a conseguir los churros haciendo un minijuego!!!! ";
            //TextoDelDialogo.text = "Busca a Ivo y el te va a dar las instrucciones";
            TextoDelDialogo.text = TextoRanzo[0];





            dialogoUI.SetActive(true);
        }



    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ranzo"))
        {
            //TextoDelDialogo.text = "Busca a Ivo y el te va a dar las instrucciones";
            dialogoUI.SetActive(false);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            IncDialogo++;

            if (IncDialogo == 4)
            {
                IncDialogo = 0;
            }

            TextoDelDialogo.text = TextoRanzo[IncDialogo];

        }

    }
}

