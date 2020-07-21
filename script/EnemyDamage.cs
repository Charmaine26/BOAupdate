using System.Collections;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
   
   int speed = 200;
   public int damage = 5;

    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {

        damage = Random.Range (10, 20);
        other.gameObject.GetComponent<HealthController> (). TakeDamage(damage);

    }

}
