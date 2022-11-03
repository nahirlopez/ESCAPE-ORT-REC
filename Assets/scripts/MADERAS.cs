using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MADERAS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public InventorySO inventario;
    public GameObject maderauno;
    public GameObject maderados;
    // Update is called once per frame
    void Update()
    {
        if (inventario.madera1 == true)
        {
            maderauno.SetActive(false);
        }
        if (inventario.madera2 == true)
        {
            maderados.SetActive(false);
        }
    }
}
