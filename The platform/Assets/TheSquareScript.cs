using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D player;
    public float speed = 5f;
    public float Jump = 5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InputHandler();
    }
    void InputHandler()
    {
        float Movement_RightLeft = Input.GetAxis("Horizontal");
        float Movement_UpDown = Input.GetAxis("Vertical");
        if ((Movement_RightLeft != 0f) || (Movement_UpDown != 0f))
        {
             player.velocity = new Vector2(Movement_RightLeft * speed, Movement_UpDown*speed);
        }

       
    }
}
