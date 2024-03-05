using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{

    public float speed, smoothTime = 0.5f, rotationSpeed;
    private Vector3 target, currentVelocity;
    private Quaternion rotationTarget;
    void Start()
    {
        target = new Vector3(3 ,0.930000007f ,-5.11000013f);
        rotationTarget = new Quaternion(0,0,0.3f,1);
    }
    void Update()
    {

        //this.gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
        //this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, target, speed*Time.deltaTime);
        //this.gameObject.transform.position = Vector3.SmoothDamp(this.gameObject.transform.position, target, ref currentVelocity, speed*Time.deltaTime);
        //this.gameObject.transform.position = Vector3.Lerp(this.gameObject.transform.position, target, speed * Time.deltaTime);
        
        //this.gameObject.transform.rotation = new Quaternion(0.3f, 0, 0, 1);
        //this.gameObject.transform.Rotate(new Vector3(1,0,0) * rotationSpeed * Time.deltaTime);
        if(Input.GetKey("e"))
        {
            this.gameObject.transform.rotation = Quaternion.RotateTowards(this.gameObject.transform.rotation, rotationTarget, rotationSpeed*Time.deltaTime);
        }
        else
        {
            this.gameObject.transform.rotation = Quaternion.RotateTowards(this.gameObject.transform.rotation, new Quaternion(0,0,0,1), rotationSpeed*Time.deltaTime);            
        }
    }
}
