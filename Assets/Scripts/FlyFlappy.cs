using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyFlappy : MonoBehaviour
{
    // Start is called before the first frame update
    //controles del pajaro
    //saltar
    
    public GameManager gameManager;
    [SerializeField] public float velocity = 1;
    private Rigidbody2D _rigidbody2D;

    //audio
    private AudioSource fondo;
    void Start()
    {
         _rigidbody2D = GetComponent<Rigidbody2D>();
         fondo = GetComponent<AudioSource>();
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
        fondo.Stop();
        
        
    }
}
