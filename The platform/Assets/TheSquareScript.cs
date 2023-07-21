using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D myrigidbody;
    public float Moveleftandright;
    public float Jump;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) == true)
        {
            myrigidbody.velocity = Vector2.up * Jump;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += (Vector3.left * Moveleftandright) * Time.deltaTime;
        }
         if (Input.GetKey(KeyCode.D))
        {
            transform.position += (Vector3.left * Moveleftandright) * Time.deltaTime * -1;
        }
    }
}
