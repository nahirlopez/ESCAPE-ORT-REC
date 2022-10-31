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
    public GameObject fps;
    
    GameObject camara;
    
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
}
