using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    private NavMeshAgent _nav;
    private Transform _player;
    private EnemyHealth _enemyHealth;

    void Start()
    {
        _nav = GetComponent<NavMeshAgent>();
        _player = GameObject.FindGameObjectWithTag("Player").transform;
        _enemyHealth = GetComponent<EnemyHealth>();
    }

    void Update()
    {
        if (_enemyHealth.Health > 0)
        {
            _nav.SetDestination(_player.position);
        }
        else
        {
            _nav.enabled = false;
        }
    }
}