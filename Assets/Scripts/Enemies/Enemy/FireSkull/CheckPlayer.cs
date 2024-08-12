using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlayer : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player");
            gameObject.SetActive(false);
        }
    }
}
