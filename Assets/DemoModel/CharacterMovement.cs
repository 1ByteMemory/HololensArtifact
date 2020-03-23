using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    Rigidbody rb;

    MagicSpell spell;

    public float moveSpeed = 5;
    public float mouseSensitivity = 10;

    public GameObject head;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        spell = GetComponent<MagicSpell>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        Look();

        Fire();
    }


    void Move()
    {
        
        if (Input.GetAxis("Vertical") != 0)
        {
            rb.AddForce(transform.forward * Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime, ForceMode.Impulse);
        }
        if (Input.GetAxis("Horizontal") != 0)
        {

            rb.AddForce(transform.right * Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, ForceMode.Impulse);
        }
    }

    void Look()
    {
        Vector3 mouse = new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X")) * mouseSensitivity;

        transform.localEulerAngles += mouse;
        
    }

    void Fire()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            spell.CastFireball();
        }
    }

}
