using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //public GameObject asteroid;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if(time>3f)
        {
            // GameObject temp=Instantiate(ObjectPoolScript.instance.GetObjectsFromPool("Asteroid"),new Vector3(Random.Range(-8.0f, 8f),4f,0f),Quaternion.identity);
            GameObject temp = (ObjectPoolScript.instance.GetObjectsFromPool("Asteroid"));
            temp.transform.position=new Vector3(Random.Range(-8.0f, 8f), 4f, 0f);
            temp.SetActive(true);
            time = 0;
            /* if (temp != null)
             {
                 this.transform.position = temp.transform.position+new Vector3(Random.Range(-8.0f, 8f), 4f, 0f);
                 temp.SetActive(true);
                 time = 0;
             }*/
        }
       

    }
}
