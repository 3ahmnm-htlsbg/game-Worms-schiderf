using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
    public KeyCode jumpKey;
    public KeyCode fowardKey;
    public KeyCode backKey;
    public KeyCode downKey;
    public KeyCode shootKey;
    public Rigidbody rb;
    public Vector3 x;
    public Vector3 y;
    public GameObject projectile;
    public Vector3 Position;
    public Quaternion Quat;
    public GameObject Weapon;
    public Vector3 PosW;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(jumpKey))
        {
            Debug.Log("Jump taste wurde gedrückt");
            rb.AddForce(x);
        }

        if (Input.GetKeyDown(fowardKey))
        {
            Debug.Log("Forwärts taste wurde gedrückt");
            rb.AddForce(y);
        }

        if (Input.GetKeyDown(backKey))
        {
            Debug.Log("Zurück taste wurde gedrückt");
            rb.AddForce(-y);
        }

        if (Input.GetKeyDown(downKey))
        {
            Debug.Log("down taste wurde gedrückt");
            rb.AddForce(-x);
        }

        if (Input.GetKeyDown(shootKey))
        {
            Debug.Log("Pew Pew");
            PosW = Weapon.transform.position;
            Instantiate(projectile, PosW, Quat);
        }
    }
}