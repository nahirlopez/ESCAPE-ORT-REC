using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class raycaster : MonoBehaviour
{
    [SerializeField] int IncDialogo = 0;
    [SerializeField] GameObject NPC;

    [SerializeField] string[] Dialoguito;
    [SerializeField] TextMeshProUGUI txt_dialogo;
    [SerializeField] GameObject dialogoUI;


    //PARA AGARRAR OBJETOS
    bool inRange = false;
    public GameObject pickableInRange;
    public GameObject door;
    public Text tecla;
    bool canopen = false;
    int contador = 0;
    bool EXIT;
    bool isopen;
    bool isNPC;
    public bool openabledoor = false;

    public GameObject[] objetos;
    public GameObject netbook;
    public InventorySO inventario;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isNPC)
        {
            DialogueName NPCName = NPC.GetComponent<DialogueName>();
            

                Dialoguito = NPCName.Dialogo;
                txt_dialogo = NPCName.TextoDelDialogo;
                dialogoUI = NPCName.Master;

            txt_dialogo.text = Dialoguito[IncDialogo];
            dialogoUI.SetActive(true);
        }
        else if (dialogoUI && isNPC == false)
        {
            dialogoUI.SetActive(false);
        }
        
        
        if (contador == 5)
        {
            EXIT = true;
        }
        if (Input.GetKeyDown(KeyCode.R) && inRange)
        {

            pickableInRange.SetActive(false);


            pickable pickablescript = pickableInRange.GetComponent<pickable>();

            if (pickablescript)
            {
                pickablescript.tick.SetActive(true);
                Debug.Log("activado");
            }
            contador++;

            int i = 0;
            while (i < objetos.Length)
            {
                if (objetos[i] == null)

                {
                    objetos[i] = pickableInRange;
                    break;

                }

                else

                {
                    i++;

                }

            }


            for (int e = 0; e < objetos.Length; e++)
            {
                if (objetos[e] && objetos[e].name == "BronzeKey")
                {
                    canopen = true;
                    break;
                }

            }
            pickableInRange = null;
            inRange = false;



        }

        if (Input.GetKeyDown(KeyCode.R) && canopen)
        {
            if (isopen && (Input.GetKeyDown(KeyCode.R) && canopen))
            {
                
                canopen = false;
                pickableInRange.SetActive(false);
                pickableInRange = null;
            }
        }




        if (Input.GetKeyDown(KeyCode.R) && EXIT && pickableInRange)
        {
            pickableInRange.SetActive(false);
            contador = 0;
            pickableInRange = null;
        }

        if (Input.GetKeyDown(KeyCode.E) && isNPC)
        {
            IncDialogo++;
            
            if (IncDialogo == Dialoguito.Length)
            {
                IncDialogo = 0;
            }

            

        }

        if (pickableInRange || door)
        {
            tecla.text = "'R' para interactuar";
        }


        if (Input.GetKeyDown(KeyCode.R) && openabledoor && door)
        {
            door.SetActive(false);
            
        }
        
    }

    void FixedUpdate()
    {
        RaycastHit hit;
        //   // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 3f))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);

            if (hit.collider.gameObject.CompareTag("pickable"))
            {
                inRange = true;
                isopen = false;
                pickableInRange = hit.collider.gameObject;
            }
            if (hit.collider.gameObject.CompareTag("open"))
            {

                isopen = true;
                inRange = false;
                pickableInRange = hit.collider.gameObject;

            }
            if (hit.collider.gameObject.CompareTag("exit"))
            {
                inRange = false;
                isopen = false;
                pickableInRange = hit.collider.gameObject;

            }
            if (hit.collider.gameObject.CompareTag("NPC"))
            {
                NPC = hit.collider.gameObject;
                isNPC = true;

            }
            if (hit.collider.gameObject.CompareTag("door"))
            {
               
                door = hit.collider.gameObject;
                openabledoor = true;


            }
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
            inRange = false;
            pickableInRange = null;
            door = null;
            tecla.text = "";
            //dialogoUI.SetActive(false);
            NPC = null;
            isNPC = false;
            IncDialogo = 0;
            openabledoor = false;
            
        }
    }
}
