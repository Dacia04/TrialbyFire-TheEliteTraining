using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSkullManager : MonoBehaviour
{
    public EnemySO EnemySO;
    public static float TimeEnable {get;set;}
    public static float TimeDisable {get;set;}
    public static bool ShouldSpawn {get;set;}
    public GameObject FireSkull;
    [SerializeField]private GameObject Target;
    private Rigidbody2D Rigidbody2D;
    private float distance;

    private void Start() {
        distance = Target.transform.position.x - transform.localPosition.x;
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Spawn();
    }

    private void Update()
    {
        transform.localPosition = new Vector3(Target.transform.position.x - distance, transform.localPosition.y, transform.localPosition.z);
        Rigidbody2D.velocity = new Vector2(Target.GetComponent<Rigidbody2D>().velocity.x,0f);
        if(Time.time - TimeDisable > EnemySO.FireSkullData.TimeReset   && ShouldSpawn)
        {
            Spawn();
        }
    }

    private void Spawn()
    {
        FireSkull.transform.position = transform.position;
        FireSkull.SetActive(true);
        TimeEnable= Time.time;
        ShouldSpawn = false;
    }
            

}
