using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thorn : MonoBehaviour, IAttackable
{
    public int Attack;
    public float time;
    private float timeStart;
    public bool IsAttackEnd;
    private Animator animator;

    private void Awake() {
        animator = GetComponent<Animator>();
    }


    private void OnEnable() {
        timeStart = Time.time;
        CameraShake.instance.ShakeCamera(0.2f);
    }

    private void Update() {
        if(Time.time > timeStart + time)
        {
            animator.SetBool("IsDisappear",true);
        }
    }
    private void OnDisable() {
        CameraShake.instance.ShakeCamera(0.2f);
        animator.SetBool("IsDisappear",false);
    }

    public int GetAttack()
    {
        return Attack;
    }

    public void DisableGameObject()
    {
        gameObject.SetActive(false);
    }
}
