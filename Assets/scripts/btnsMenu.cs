using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class btnsMenu : MonoBehaviour
{

    public GameObject comojugar;
    public GameObject FPS;
    // Start is called before the first frame update
    void Start()
    {
        FPS = GameObject.FindGameObjectWithTag("BOTON JUGAR");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void JUGAR()
    {
        SceneManager.LoadScene("COMIENZO");
        FPS.SetActive(true);
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
