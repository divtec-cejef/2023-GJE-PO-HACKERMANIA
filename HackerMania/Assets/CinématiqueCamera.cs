using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinématiqueCamera : MonoBehaviour
{
    public float duration = 5f;
    private float timer = 0f


    // Update is called once per frame
    void Update()
    {
       timer += Time.daltaTime;
       
       if (timer >= duration) {
           gameObject.SetActive(false);
       }
    }
}
