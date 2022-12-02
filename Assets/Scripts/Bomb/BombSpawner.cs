using UnityEngine;

public class BombSpawner : MonoBehaviour
{


    [SerializeField] private Bomb _bombPrefab;
    [SerializeField] private uint _coinCount;
    [SerializeField] private float _coinDistance;

    private void Start()
    {
        for (int i = 0; i < _coinCount; i++)
        {

            var bomb = Instantiate(_bombPrefab, transform.position, Quaternion.identity);
            bomb.transform.position = new Vector3(Random.Range(-_coinDistance, _coinDistance),
                                       Random.Range(-_coinDistance, _coinDistance),
                                       Random.Range(-_coinDistance, _coinDistance));
        }
    }
}
