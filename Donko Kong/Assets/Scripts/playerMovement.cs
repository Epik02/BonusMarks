using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 1;
    float inputx = 0;
    float inputy = 0;
    float jumpmath = 0;
    float x = 0;
    // Update is called once per frame
    void Update()
    {

        inputx = UnityEngine.Input.GetAxis("Horizontal");
        inputy = UnityEngine.Input.GetAxis("Vertical");

        GetComponent<Rigidbody2D>().velocity = new Vector2(inputx * speed, inputy * speed);

        if (Input.GetKeyDown("Space"))
        {
            x = x + 0.01f;
            jumpmath = -1 * (Mathf.Pow(x - 3, 2)) + 9;
            GetComponent<Rigidbody2D>().MovePosition(new Vector3(transform.position.x, jumpmath, 0));
        }
        else
        {
            x = 0;
        }
    }
}
