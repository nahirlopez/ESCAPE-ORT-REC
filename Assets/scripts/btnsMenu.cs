using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class btnsMenu : MonoBehaviour
{

    public GameObject comojugar;
    
    public InventorySO inventario;

    // Start is called before the first frame update
    void Start()
    {
        
        inventario.start = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            inventario.start = true;
         SceneManager.LoadScene("COMIENZO");
            
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            comojugar.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            comojugar.SetActive(false);
        }
    }

    public void JUGAR()
    {
        inventario.start = true;
        SceneManager.LoadScene("COMIENZO");
        
    }

    public void ComoJugar()
    {
        comojugar.SetActive(true);
    }

    public void volvermenu()
    {
        comojugar.SetActive(false);
    }
}
