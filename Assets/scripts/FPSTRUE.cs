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
        inventario.HasBronzeKey = false;
        inventario.win = false;
        inventario.madera1 = false;
        inventario.madera2 = false;
        inventario.HasGoldenKey = false;
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
