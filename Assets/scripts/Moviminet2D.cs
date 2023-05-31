using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviminet2D : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;
    public float jumpForce;
    public int maxJump;

    int hasJump;
    Rigidbody2D rb;


    public GameObject screamer;
    public GameObject portalfinal;
    public AudioSource source;
    public AudioClip SCREAM;
    public AudioClip OOF;

    void Start()
    {
        hasJump = maxJump;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        transform.eulerAngles = (new Vector3(0, 0, 0));

        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.Translate(0, 0, movementSpeed);
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.Translate(0, 0, -movementSpeed);
        //}
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(movementSpeed, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space) && hasJump >= 0)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
            hasJump--;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "ground")
        {
            hasJump = maxJump;
        }

        //void OnCollisionEnter(Collision col)
        {
            if (col.gameObject.name == "LosingCube")
            {

                Debug.Log("Contacto");
                transform.position = new Vector3(-7.57f, -2.49f, 0f);
                source.clip = OOF;
                source.Play();
            }

        }
        if (col.gameObject.name == "PortalScreamer")
        {

            Debug.Log("Contacto");
            transform.position = new Vector3(-7.57f, -2.49f, 0f);
            screamer.SetActive(true);
            source.clip = SCREAM;
            source.Play();

            StartCoroutine(Timedelay());

            portalfinal.SetActive(true);

        }


    }
    IEnumerator Timedelay()
    {
        yield return new WaitForSeconds(5);
        screamer.SetActive(false);

    }

}



