using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balon_Creator : MonoBehaviour
{
    public GameObject baloon;
    float balonOlusturmaSuresi = 1f;
    float zamanSayaci = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        zamanSayaci -= Time.deltaTime;
        if(zamanSayaci <0)
        {
            GameObject hareket = Instantiate(baloon, new Vector3(Random.Range(-2.5f, 2.5f), -6, 0),Quaternion.Euler(0,0,0));
            hareket.GetComponent<Rigidbody2D>().AddForce(new Vector3(0,100f,0));
            zamanSayaci = balonOlusturmaSuresi;
        }
    }
}
