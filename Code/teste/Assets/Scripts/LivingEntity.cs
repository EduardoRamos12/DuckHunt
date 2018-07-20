using UnityEngine;
using System.Collections;

public class LivingEntity : MonoBehaviour, IDamageable
{

    public float startingHealth;
    protected float health;
    protected bool dead;
       
    public event System.Action OnDeath;

    protected virtual void Start()
    {
        health = startingHealth;
    }

    public void TakeHit(float damage, RaycastHit hit)
    {
        health -= damage;

        if (health <= 0 && !dead)
        {
            Die();
        }
    }

    protected void Die()
    {
        Debug.Log("matar");
        dead = true;
        if (OnDeath != null)
        {
            OnDeath();
        }
        Score score = GameObject.FindGameObjectWithTag("Score").GetComponent(typeof(Score)) as Score;
        
        score.incrementScore(gameObject);
        GameObject.Destroy(gameObject);
    }
}