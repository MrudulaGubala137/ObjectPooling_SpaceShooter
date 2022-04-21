using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int playerSpeed;
     int playerHealth=10;
    int maxHealth=10;
    // public GameObject bulletPrefab;
    public Slider healthBar;
    public Vector3 offSet;
    public bool isGameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver)
       {
            float inputX = Input.GetAxis("Horizontal");
            healthBar.value = (float)playerHealth/10;
            transform.Translate(0f, inputX * playerSpeed * Time.deltaTime, 0f);
            //Clamp player position within gameWindow

            if (Input.GetKeyDown(KeyCode.Space))
            {

                GameObject tempBullet = ObjectPoolScript.instance.GetObjectsFromPool("Bullet");
                tempBullet.transform.position=this.transform.position+offSet;
           // transform.Translate(0f, 0f, 1f);
            tempBullet.SetActive(true);
                    //Instantiate(bulletPrefab, transform.position + offSet, Quaternion.identity);
            }
       }
        if(playerHealth==0)
        {
            Destroy(gameObject);
            isGameOver = true;
            print("GameOver");

        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag =="Asteroid")
        {
            playerHealth--;
            collision.gameObject.SetActive(false);
            print("player Health Dec:"+playerHealth);
            
        }
       
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Health" && playerHealth < maxHealth)
        {
            playerHealth = Mathf.Clamp(playerHealth + 1, 0, maxHealth);
            collision.gameObject.SetActive(false);
            print("player Health inc:" + playerHealth);
        }
    }
}
