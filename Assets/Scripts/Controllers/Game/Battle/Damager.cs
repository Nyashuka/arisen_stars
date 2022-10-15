using System;
using UnityEngine;

public class Damager : MonoBehaviour
{
    [SerializeField] private int _damage;
    private Action DeathActionEvent;

    public void SetDamage(int damage)
    {
        _damage = damage;
    }

    public void OnDeathAction(Action onHit)
    {
        DeathActionEvent += onHit;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out IDamageable damageable))
        {
            if (!damageable.MakeDamage(_damage))
            {
                DeathActionEvent?.Invoke();
            }

            Destroy(gameObject);
        }
    }
}