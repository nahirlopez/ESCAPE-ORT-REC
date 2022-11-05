using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SONIDOS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        source = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    AudioSource source;
    public AudioClip grito;
    public AudioClip toctoc;
    public AudioClip tension;
    public AudioClip ouch;
    public AudioClip cueva;
    //FirstPersonController fpc;
    //public UnityStandardAssets.Characters.FirstPerson.FirstPersonController controller;

    public GameObject FPS;
     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "gritito")
        {
            source.clip = grito;
            source.Play();
        }

        if (other.gameObject.tag == "toctoc")
        {
            source.clip = toctoc;
            source.Play();
        }

        if (other.gameObject.tag == "arañita")
        {
            source.clip = ouch;
            source.Play();
        }
        if (other.gameObject.tag == "cueva")
        {
            source.clip = cueva;
            source.Play();
        }

        if (other.gameObject.tag == "tension")
        {
            source.clip = tension;
            source.Play();
            //fpc = GameObject.FindObjectOfType<FirstPersonController>();
            //fpc.m_IsWalking = false;
        }
           
    }

   
}
