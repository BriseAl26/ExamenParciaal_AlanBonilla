using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovJugador : MonoBehaviour
{
    [SerializeField] private float speed = 8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))


            transform.Translate(Vector3.left * Time.deltaTime * speed);


        if (Input.GetKey(KeyCode.A))


            transform.Translate(Vector2.right * Time.deltaTime * speed);


    }
}
