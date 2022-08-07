using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balon_Destroyer : MonoBehaviour
{

    public GameObject  patlamaAnim;

    private void OnMouseDown()
    {
        GameObject patlamaAnimasyonu = Instantiate(patlamaAnim, transform.position, transform.rotation);
        Destroy(this.gameObject);
        Destroy(patlamaAnimasyonu,0.51f);
    }

}
