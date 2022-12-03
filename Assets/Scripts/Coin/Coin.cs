using UnityEngine;
using UnityEngine.Events;

public class Coin : Entity
{

    [SerializeField] private Rigidbody _coin;
    [SerializeField] private CoinPickParticless _particless;

    public static event UnityAction PickCoin;

    public override void Die(Airplane airplane)
    {
        Instantiate(_particless.gameObject, transform.position, Quaternion.identity);
        _Sound.Play();
        Destroy(gameObject, 0.1f);
        PickCoin?.Invoke();

    }


    private int rotation = 1;
    public void Start()
    {
        rotation = Random.RandomRange(0, 2) == 1 ? 1 : -1;
    }


    public void FixedUpdate()
    {
        _coin.AddTorque(0f, 0.02f * rotation, 0f);
    }
}

public abstract class Entity : MonoBehaviour
{
    [SerializeField] protected AudioSource _Sound;

    public abstract void Die(Airplane airplane);
}
