using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public float speed = 3f;

    void Update() {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        transform.position = new Vector3(pos.x, transform.position.y, transform.position.z);

        float hor = Input.GetAxisRaw("Horizontal");
        Vector3 dir = new Vector3(hor, 0, 0);

        transform.Translate(dir.normalized * Time.deltaTime * speed);
    }
    void OnTriggerEnter(Collider collision) {
            if(collision.gameObject.CompareTag("Car")) {
                Destroy(gameObject);
                Time.timeScale = 0;
                SceneManager.LoadScene(2);
        }
    }
}
