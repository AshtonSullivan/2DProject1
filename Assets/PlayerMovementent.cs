using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D PlayersRB = GetComponent<Rigidbody2D>();
            PlayersRB.AddForce(Vector2.up * 200f);
        }

        if (Input.GetKeyDown(KeyCode.RightCommand))
        {
            Rigidbody2D PlayersRB = GetComponent<Rigidbody2D>();
            PlayersRB.AddForce(Vector2.right * 200f);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            Rigidbody2D PlayersRB = GetComponent<Rigidbody2D>();
            PlayersRB.AddForce(Vector2.left * 200f);
        }




    }
}
