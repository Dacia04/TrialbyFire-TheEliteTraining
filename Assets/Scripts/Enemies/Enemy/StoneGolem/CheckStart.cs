using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckStart : MonoBehaviour
{
    public Golem Golem;
    public Player Player;
    private void Start() {
        Golem.enabled = false;
    }

    private void Update() {
        if(Player.playerStateMachine.ReusableData.CurrentHealth <= 0 )
        {
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Player"))
        {
            Golem.enabled = true;
            
        }
    }
}
