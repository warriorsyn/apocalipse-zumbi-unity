using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaJogador : MonoBehaviour
{
    public float Velocity = 10;
    Vector3 move;

    void Update()
    {
        float axisX = Input.GetAxis("Horizontal");

        float axixZ = Input.GetAxis("Vertical");

        move = new Vector3(axisX, 0, axixZ);


        if (move != Vector3.zero)
        {
            GetComponent<Animator>().SetBool("Movendo", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("Movendo", false);
        }



        //transform.Translate(Time.deltaTime * Velocity * move);

    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + (Time.deltaTime * Velocity * move));

    }
}
