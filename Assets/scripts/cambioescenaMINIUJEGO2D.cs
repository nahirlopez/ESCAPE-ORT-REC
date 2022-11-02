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
    public InventorySO inventario;

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnCollisionEnter(Collision col)
    {
        if (col.gameObject == tp1)
        {
            SceneManager.LoadScene("Juego1");

            fps.SetActive(false);


        }
        Debug.Log(col.gameObject);
        
    }
     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == tp2)
        {

            fps.transform.position = new Vector3(-303.6549f, 15.10432f, -2743.993f);
            fps.transform.eulerAngles = new Vector3 (0, 180.063f, 0);


        }
        
        if(other.gameObject == FINAL)
        {
            
            fps.transform.position = new Vector3(539.8755f, 156.493f, -490.7579f);
            inventario.madera2 = true;

        }
    }
}
