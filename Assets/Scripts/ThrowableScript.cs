using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class ThrowableScript : MonoBehaviour
{
    public Rigidbody rb;
  
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
            Debug.Log("target touch");
            rb.isKinematic = true;
            StartCoroutine(SelfDestruct());
        }

        if (collision.gameObject.tag == "Ground")
        {
            StartCoroutine(SelfDestruct());
        }
    }

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(7.5f);
        //Destroy(gameObject);
        //Rigidbody clone;
        //clone = Instantiate(rb, new Vector3(1.94f, 2f, 5.8f), transform.rotation);
        //Instantiate(rb, new Vector3(-7.5f, 2f, 5.8f), transform.rotation);
        rb.isKinematic = false;
        transform.position = new Vector3(1.94f, 3f, 5.8f);
    }
}
