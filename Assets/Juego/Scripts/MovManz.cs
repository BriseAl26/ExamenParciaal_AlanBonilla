using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovManz : MonoBehaviour
{

    public float vel;

    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(Vector3.left * vel * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * vel * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("pared"))
        {
            Destroy(gameObject);
        }
    }

}
