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
      

        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == tp2)
        {

            fps.transform.position = new Vector3(-294.1111f, 16.99974f, -2709.42f);

        }
        if(other.gameObject == FINAL)
        {
            
            fps.transform.position = new Vector3(539.8755f, 156.493f, -490.7579f);
            inventario.madera2 = true;

        }
    }
}
