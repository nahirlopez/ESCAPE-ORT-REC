using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioescenaMINIUJEGO2D : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }
    public GameObject tp1;
    public GameObject tp2;
    public GameObject fps;
    public GameObject FINAL;
    
    GameObject camara;
    InventorySO inventario;
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject == tp1)
        {
            SceneManager.LoadScene("Juego1");

            fps.SetActive(false);


        }
        if (col.gameObject == tp2)
        {

            fps.transform.position = new Vector3(-302.7511f, 285917f, -2743.33f);
           
        }

        if (col.gameObject == FINAL)
        {
            inventario.madera2 = true; 

        }
    }
}
