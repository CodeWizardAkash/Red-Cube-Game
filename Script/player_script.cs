using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{   
    public Rigidbody rigidbody;
    public float jump = 10;
    public float force = 1000f;
    public float speed = 10f;
    public float maxZ;
    public float minZ;
    void Start(){
        // Debug.Log("Hello World!");
        // Debug.Log(transform.position);

    }
    void Update()
    {   
        //--Clamping movement--
        Vector3 playerpos = transform.position;
        // if(playerpos.z < minZ){
        //     playerpos.z = minZ;
        // }
        // if(playerpos.z > maxZ){
        //     playerpos.z = maxZ;
        // }
        // playerpos.x
        playerpos.z = Mathf.Clamp(playerpos.z, minZ, maxZ);
        transform.position = playerpos;
        playerpos.y = Mathf.Clamp(playerpos.y, 1, 4);
        transform.position = playerpos;
        // Debug.Log("I am Update Mathod!");
        // transform.position = transform.position + new Vector3(-10f*Time.deltaTime,0,0);
        // rigidbody.AddForce(-1000f*Time.deltaTime,0,0);

        //--Right & left Move--
        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            // Debug.Log("Right Arrow Key is Pressed");
            transform.position = transform.position + new Vector3(0,0,speed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            // Debug.Log("Left Arrow Key is Pressed");
            transform.position = transform.position - new Vector3(0,0,speed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.Space)){
            rigidbody.AddForce(Vector3.up * jump);
        }
    }
    private void FixedUpdate()
    {
        rigidbody.AddForce(-force*Time.deltaTime, 0, 0);
    }
}
