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
            
            Destroy(rb, 10);
            Rigidbody clone;
            clone = Instantiate(rb, new Vector3(2.79f, 2f, 5.8f), new Quaternion());
        }
    }
}
