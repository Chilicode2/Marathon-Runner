using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    //private bool isGrounded;

    private Rigidbody2D Rigidbody2D;

    public float runSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        //isGrounded = false;s
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(h, 0, v);
            Rigidbody2D.velocity = movement * runSpeed * Time.deltaTime;
    }
}
