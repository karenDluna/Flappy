using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyFlappy : MonoBehaviour
{
    // Start is called before the first frame update
    //controles del pajaro
    //saltar

    [SerializeField] public float velocity = 1;
    private Rigidbody2D _rigidbody2D;
    void Start()
    {
         _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //salto
            _rigidbody2D.velocity = Vector2.up * velocity;
        }
    }
}
