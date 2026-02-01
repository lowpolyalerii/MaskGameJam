using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int health;

    private void Start()
    {
        health = maxHealth;

    }

    // Update is called once per frame
    public void TakeDamage(int damage)
    {
       health -= damage;
       if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
