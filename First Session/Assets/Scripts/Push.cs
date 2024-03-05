using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Push : MonoBehaviour
{
    public Rigidbody SpherePhysic;
    public Transform Camera;
    public GameManager GameAdmin;
    public float ForceValue, JumpForce;

    private bool canJump = true;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void FixedUpdate()
    {
        if(Input.GetKey("d"))
        {
            SpherePhysic.AddForce(Camera.transform.right * ForceValue * Time.deltaTime, ForceMode.VelocityChange);
        }

        if(Input.GetKey("a"))
        {
            SpherePhysic.AddForce(-Camera.transform.right * ForceValue * Time.deltaTime, ForceMode.VelocityChange);
        }

        if(Input.GetKey("w"))
        {
            SpherePhysic.AddForce(Camera.transform.forward * ForceValue * Time.deltaTime, ForceMode.VelocityChange);
        }

        if(Input.GetKey("s"))
        {
            SpherePhysic.AddForce(-Camera.transform.forward * ForceValue * Time.deltaTime, ForceMode.VelocityChange);
        }

        if(Input.GetKey(KeyCode.Space))
        {
            if(canJump)
            {
                SpherePhysic.AddForce(0, JumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
                canJump = false;
            }
        }
    }

    void OnCollisionEnter(Collision CollidedObject)
    {
        if(CollidedObject.gameObject.tag=="Ground" && SpherePhysic.velocity.y<=0)
        {
            Debug.Log("we have the ground");
            canJump = true;
        }

        if(CollidedObject.gameObject.tag=="Enemy")
        {
            GameAdmin.GameOver();
        }
    }
}
