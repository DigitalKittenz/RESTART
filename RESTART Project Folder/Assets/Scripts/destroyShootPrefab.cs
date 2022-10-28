using UnityEngine;
public class destroyShootPrefab : MonoBehaviour
{
    public GameObject explosion;
    void OnCollisionEnter()
    {
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}