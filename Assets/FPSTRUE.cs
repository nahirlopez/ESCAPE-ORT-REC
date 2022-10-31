using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSTRUE : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject fps;
    public InventorySO inventario;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inventario.win == true)
        {
            fps.SetActive(true);
        }
    }
}
