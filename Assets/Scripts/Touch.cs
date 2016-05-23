using UnityEngine;
using System.Collections;

public class Touch : MonoBehaviour {

    [SerializeField]
    private GameObject explosionPrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject explosion = (GameObject)Instantiate(explosionPrefab, touchPosition, Quaternion.identity);
            Destroy(explosion, 1.5f);
        }
    }
}
