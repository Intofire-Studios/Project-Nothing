using UnityEngine;

public class MoveObjects : MonoBehaviour {

    public float speed = 2f;

    void FixedUpdate() {
        speed += Time.deltaTime;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (transform.position.y < -6)
            Destroy(gameObject);
    }

}
