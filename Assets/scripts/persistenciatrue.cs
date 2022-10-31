using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class persistenciatrue : MonoBehaviour
{
    public static persistenciatrue instance;
    public InventorySO inventario;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
            {
                Destroy(gameObject);
            }
        }

    }

}
