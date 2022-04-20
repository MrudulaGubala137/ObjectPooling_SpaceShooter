using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int playerSpeed;
    public GameObject bulletPrefab;
    public Vector3 offSet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        transform.Translate(0f,inputX * playerSpeed*Time.deltaTime,0f);
        //Clamp player position within gameWindow
       
        if(Input.GetKey(KeyCode.Space))
        {
           
            Instantiate(bulletPrefab, transform.position + offSet, Quaternion.identity);
        }
    }
}
