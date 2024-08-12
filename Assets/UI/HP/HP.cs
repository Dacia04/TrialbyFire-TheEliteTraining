using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    private int hp1,hp2;
    public Player Player;
    public Golem Golem;
    public TMPro.TextMeshProUGUI HPText;
    void Start()
    {
        InvokeRepeating("GetFPS",1,1);
    }

    private void GetFPS()
    {
        hp1 = Player.playerStateMachine.ReusableData.CurrentHealth;
        hp2 = GolemReusableData.Health;
        //HPText.text = "HP Player: " + hp1.ToString() + " HP Golem: "+  hp2.ToString();
        HPText.text = "HP Player: " + hp1.ToString();
    }
}
