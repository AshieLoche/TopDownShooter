using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    public float spead = 5f;

     void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        horizontal *= spead * Time.deltaTime;

        transform.Translate(new Vector3(0f, horizontal, 0f));
    }
}