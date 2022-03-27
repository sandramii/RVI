using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testFizika : MonoBehaviour
{
    [SerializeField] Rigidbody rigidbody;
    [SerializeField] MeshRenderer meshRenderer;

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.J))
        {
            // force dodaje silu vektora na objekat u svakom frame-u
            rigidbody.AddForce(Vector3.up*100, ForceMode.Force);
        }
        if(Input.GetKeyUp(KeyCode.K))
        {
            // impuls dodaje silu vektora na objekat samo u jednom frame-u
            rigidbody.AddForce(Vector3.up*4, ForceMode.Impulse);
        }
        if(Input.GetKeyUp(KeyCode.L))
        {
            // vellocity change dodaje brzinu na objekat konstantno
            rigidbody.AddTorque(Vector3.up*10, ForceMode.VelocityChange);
        }
    }

    // kada drugi objekat udje u kocku ona se boji u crveno
    void OnTriggerEnter(Collider other)
    {
        meshRenderer.material.color = Color.red;
    }

    // kada objekat izadje iz kocke ona se boji u belo
    void OnTriggerExit(Collider other)
    {
        meshRenderer.material.color = Color.white;
    }
    //kada se dodirne kocka sa drugim objektom postace plava
    void OnCollisionEnter(Collision other)
    {
        meshRenderer.material.color = Color.blue;
    }
}
