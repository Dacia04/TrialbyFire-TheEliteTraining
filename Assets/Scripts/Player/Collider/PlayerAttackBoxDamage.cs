using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackBoxDamage : MonoBehaviour
{
    public GameObject AttackEffect;
    public Transform PosAttackEffect;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("EnemyNoTouch") || other.gameObject.CompareTag("EnemyTouch"))
        {
            AttackEffect.transform.position = PosAttackEffect.position;
            AttackEffect.SetActive(true);
            CameraShake.instance.ShakeCamera(0.3f);
            //Debug.Log("Attack");
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("EnemyNoTouch") || other.gameObject.CompareTag("EnemyTouch"))
        {
            AttackEffect.transform.position = PosAttackEffect.position;
            AttackEffect.SetActive(true);
            CameraShake.instance.ShakeCamera(0.3f);
            //Debug.Log("Attack");
        }
    }
}
