using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour
{
    public float Health = 1;

    private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void TakeDamage(float damage)
    {
        if (Health <= 0)
        {
            return;
        }

        Health -= damage;
        if (Health <= 0)
        {
            Death();
        }
    }

    private void Death()
    {
        _animator.SetTrigger("Morte");
    }
}

