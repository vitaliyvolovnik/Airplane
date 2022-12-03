using UnityEngine;
using UnityEngine.Events;

public class Bomb : Entity
{

    public static event UnityAction GameEnd;

    public override void Die(Airplane airplane)
    {
      
        airplane.Die();

        _Sound.Play();
        Destroy(gameObject, 0.1f);

        GameEnd?.Invoke();

    }
}