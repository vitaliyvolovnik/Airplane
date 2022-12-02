using UnityEngine;

public class CoinSpawner : MonoBehaviour
{

    [SerializeField] private Coin _coinPrefab;
    [SerializeField] private uint _coinCount;
    [SerializeField] private float _coinDistance;
    private void Start()
    {
        for (int i = 0; i < _coinCount; i++)
        {
           
            var coin = Instantiate(_coinPrefab, transform.position, new Quaternion(0.7071067f, 0, 0, 0.7071069f));
            coin.transform.position = new Vector3(Random.Range(-_coinDistance, _coinDistance), 
                                       Random.Range(-_coinDistance, _coinDistance),
                                       Random.Range(-_coinDistance, _coinDistance));
        }
    }
    // Update is called once per frame
    
}
