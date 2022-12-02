using UnityEngine;

public class Bomb : Entity
{

    public override void Die(Airplane airplane)
    {
      
        airplane.Die();


        _Sound.Play();
        Destroy(gameObject, 0.1f);

    }
}