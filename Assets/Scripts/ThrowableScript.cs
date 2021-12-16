using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;


public class ThrowableScript : MonoBehaviour
{
    public Rigidbody rb;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "target")
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.Play();
            
            rb.isKinematic = true;

            StartCoroutine(SelfDestruct());
        }

        if (collision.gameObject.tag == "Ground")
        {
            
            audioSource = GetComponent<AudioSource>();
            audioSource.Play();
            StartCoroutine(SelfDestruct());
        }
    }

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(7.5f);
        rb.isKinematic = false;
        transform.position = new Vector3(1.94f, 3f, 5.8f);
    }
}
