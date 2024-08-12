using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GroundFall : MonoBehaviour
{
    public float timeDelay = 1f;
    public float timeReset = 2f;
    public float speed = 5f;

    private float fallModifier =0f;
    private bool IsCount = false;
    private float TimeStart;
    private Rigidbody2D Rigidbody2D;

    private Vector3 startPosition;


    private void Start() {
        startPosition = transform.localPosition;
        fallModifier = 0f;
        Rigidbody2D = GetComponent<Rigidbody2D>();
        IsCount = false;
    }

    private void Update() {
        if(IsCount && Time.time - TimeStart > timeDelay)
        {
            fallModifier = 1f;
            Invoke(nameof(SpawnGameObject),timeReset);
        }
        Rigidbody2D.velocity = new Vector2(0f,-speed * fallModifier);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            IsCount = true;
            TimeStart = Time.time;
        }
    }

    public void SpawnGameObject()
    {
        fallModifier = 0f;
        IsCount = false;
        transform.localPosition = startPosition;
    }

}
