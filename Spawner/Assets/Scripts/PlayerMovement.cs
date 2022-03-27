using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMovement : MonoBehaviour
{
   [SerializeField] Rigidbody rigidbody;
    [SerializeField] Camera cam;
    [SerializeField] Weapon weapon;
    private float speed = 5f;
    private float horizontal;
    private float vertical;

    private void Awake()
    {
        Debug.Log("Awake");
    }
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }
    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }
    // Update is called once per frame
    void Update()
    {
        GetInput();
        RotateCharacter();

        // dokle god je pritisnuto levo dugme na misu se puca, a provera
        // da li je weapon razlicito od nule je jer se proverava da li puska i dalje
        // postoji ili je izbijena
        if(Input.GetMouseButton(0))
        {
            if(weapon != null)
            {
                weapon.Shoot();
            }
        }
    }

    void FixedUpdate()
    {
        Move();
    }

    private void GetInput()
    {
        // Ovde se registruju dogadjaji kao sto su dugmici na tastaturi
        //gore dole levo desno
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

/*    private void Move()
    {
        // menja se pozicija playera u zavisnosti od registrovanih dogadjaja
        Vector3 changeInPosition = new Vector3(horizontal, 0f, vertical);
        Vector3 goToPosition = transform.position + changeInPosition * speed * Time.deltaTime;
        rigidbody.MovePosition(goToPosition);
        
        //transform.Translate(changeInPosition * Time.deltaTime * speed);
    }

    // ova funkcija sluzi da se player okrece ka mestu gde je mis
    private void RotateCharacter()
    {
        RaycastHit hit;
        if(Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity))
        {
            transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
        }
    }
*/

     private void Move()
    {
        Vector3 changeInPosition = new Vector3(horizontal, 0f, vertical);
        Vector3 goToPositon = transform.position + changeInPosition * speed * Time.deltaTime;
        rigidbody.MovePosition(goToPositon);
        // transform.Translate(changeInPosition * Time.deltaTime * speed);
    }

    private void RotateCharacter()
    {
        RaycastHit hit;
        if(Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity))
        {
            transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
        }
    }
    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}
