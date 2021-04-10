using UnityEngine;

public class MoveCoins : MonoBehaviour {

    public float speed = 1.5f;

    void FixedUpdate() {
        speed += Time.deltaTime;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (transform.position.y < -6)
            Destroy(gameObject);
    }

}
