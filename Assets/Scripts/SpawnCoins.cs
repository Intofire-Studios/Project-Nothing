using UnityEngine;
using System.Collections;

public class SpawnCoins : MonoBehaviour {

    public GameObject[] coins;
    private float[] pop = {0.45f, -1.26f, 1.33f, -0.39f};

    void Start() {
        StartCoroutine(spawnCoin());
    }

    IEnumerator spawnCoin() {
        while(true) {
            Instantiate(
                coins[Random.Range(0, coins.Length)],
                new Vector3(pop[Random.Range(0, 4)], 6f, 0),
                Quaternion.Euler(new Vector3(90, 180, 0))
            );
            yield return new WaitForSeconds(10f);
        }
    }

}
