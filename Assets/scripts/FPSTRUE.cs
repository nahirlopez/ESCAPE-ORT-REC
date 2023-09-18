using System.Collections;
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

    
    void Start()
    {
        inventario.HasBronzeKey = false;
        inventario.win = false;
        inventario.madera1 = false;
        inventario.madera2 = false;
        inventario.HasGoldenKey = false;
        inventario.start = false;
       
    }

    // Update is called once per frame
    void Update()
    {

        if (inventario.win == true)
        {
            StartCoroutine(GameFinished());
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
                ivo.GetComponent<DialogueName>().Dialogo[2] = "Ivo: Si ves otra madera en la pecera, ¡Busca a Jero!";
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
                jero.GetComponent<DialogueName>().Dialogo[1] = "Jero: Intenta agarrar la llave y ve a hablar con Ranzo";
            }
        }

        if (inventario.HasGoldenKey == true)
        {
            int i = 0;
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
            fps.SetActive(true);
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
    IEnumerator GameFinished()
    {
        yield return new WaitForSeconds(0.2f);

        fps.SetActive(true);
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
