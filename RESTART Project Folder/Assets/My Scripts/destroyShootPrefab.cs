using UnityEngine;
public class destroyShootPrefab : MonoBehaviour
{
    //this script destoys the object
    public GameObject explosion;
    void OnCollisionEnter()
    {
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}