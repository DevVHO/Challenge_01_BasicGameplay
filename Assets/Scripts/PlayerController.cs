using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalinput;
    private float Rangex = 15f;
    private float speed = 25.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalinput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*horizontalinput*Time.deltaTime*speed); 
        if(transform.position.x > Rangex)
        {
            transform.position = new Vector3(Rangex,transform.position.y,transform.position.z);
        }
        if (transform.position.x < -Rangex)
        {
            transform.position = new Vector3(-Rangex, transform.position.y, transform.position.z);
        }
    }
}
