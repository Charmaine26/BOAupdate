using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth {get;protected set;}	

    public Stats damage;
    

    // Start is called before the first frame update
    public virtual void Awake() 
    {
		currentHealth = maxHealth;
	}


   
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            TakeDamage(10);
            
        }
        
    
    }

    public void TakeDamage (int damage)
	{
		
		
		damage = Mathf.Clamp(damage, 0, int.MaxValue);

		currentHealth -= damage;
		Debug.Log(transform.name + " takes " + damage + " damage.");

        if (currentHealth <= 0)
		{
			Die();
		}
         
    }

    public virtual void Die ()
	{
		
		Debug.Log(transform.name + " died.");
	}
}
