using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * 1 * Time.deltaTime);

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            collision.gameObject.SetActive(false);
            print("bullet is made inactive");
            this.gameObject.SetActive(false);
            print("Asteroid is inactive");
        }
    }
}
