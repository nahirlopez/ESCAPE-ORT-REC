using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch2D : MonoBehaviour
{
    

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "PuntoLlegada")
        {
            SceneManager.LoadScene("COMIENZO");
            Debug.Log("Hace contacto");
        }

    }
}

