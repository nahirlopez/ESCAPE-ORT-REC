using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class raycaster : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    bool inRange = false;
    bool open = false;
    GameObject pickableInRange;
    public Text tecla;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inRange)
        {
            pickableInRange.SetActive(false);
        }

        if (inRange)
        {
            tecla.text = "'E' para interactuar";
        }
        else
        {
            tecla.text = "";
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
                pickableInRange = hit.collider.gameObject;
            }
            if (hit.collider.gameObject.CompareTag("open"))
            {
                open = true;
                pickableInRange = hit.collider.gameObject;
            }
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
            inRange = false;
            open = false;
        }
    }
}
