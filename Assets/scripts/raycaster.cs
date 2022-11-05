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
    
    bool canopen = false;
    int contador = 0;
    bool EXIT;
    bool isopen;
    bool isNPC;
    public bool openabledoor = false;

    public GameObject portalfinal;
    public Text tecla;

    

    //public GameObject[] objetos;
    public GameObject netbook;
    public InventorySO inventario;

    
    public AudioClip puerta; 

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
            dialogoUI = null;
            txt_dialogo = null;
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
               
            }
            contador++;


            //int i = 0;
            //while (i < objetos.Length)
            //{
            //    if (objetos[i] == null)

            //    {
            //        objetos[i] = pickableInRange;
            //        break;

            //    }

            //    else

            //    {
            //        i++;

            //    }

            //}


            if (pickableInRange.name == "BronzeKey")
            {
                inventario.HasBronzeKey = true;

            }
            if (pickableInRange.name == "Llave_oro")
            {
                inventario.HasGoldenKey = true;
                

            }

            pickableInRange = null;
            inRange = false;

            if (inventario.HasBronzeKey == true)
            {
                canopen = true;
            }

            if (inventario.HasGoldenKey == true)
            {
                portalfinal.SetActive(true);

            }

        }

        if (Input.GetKeyDown(KeyCode.R) && canopen)
        {
            if (isopen && (Input.GetKeyDown(KeyCode.R) && canopen))
            {
                
                canopen = false;
                pickableInRange.SetActive(false);
                pickableInRange = null;
                source.clip = puerta;
                source.Play();
            }
        }


        

        if (Input.GetKeyDown(KeyCode.R) && EXIT && pickableInRange)
        {
            pickableInRange.SetActive(true);
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
        
    if (tecla.text != null && pickableInRange == false && door == false)
        {
            tecla.text = "";
        }


        if (Input.GetKeyDown(KeyCode.R) && openabledoor && door)
        {
            door.SetActive(false);
            //source.clip = puerta;
            //source.Play();
            //door.GetComponent<Animator>().Play("NewOpenDoorAnimation");
            
        }
        
    }

    void FixedUpdate()
    {
        RaycastHit hit;
        //   // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 8f))
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
            
            inRange = false;
            pickableInRange = null;
            door = null;
            
            //dialogoUI.SetActive(false);
            NPC = null;
            isNPC = false;
            IncDialogo = 0;
            openabledoor = false;
            
        }
    }

    public void LoadReferences()
    {
        portalfinal = GameObject.FindGameObjectWithTag("PortalFinal");

        tecla = GameObject.FindGameObjectWithTag("txt_interaccion").GetComponent<Text>();

        portalfinal.SetActive(false);
    }
}
