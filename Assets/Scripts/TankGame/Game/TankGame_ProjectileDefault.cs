using System.Collections;
using UnityEngine;

public class TankGame_ProjectileDefault : MonoBehaviour
{
    [Header("Projectile Preferences")]
    [SerializeField] private float movementSpeed = 0.3f;

    public GameObject trajectory;

    void Start() => StartCoroutine("moveProjectile");

    IEnumerator moveProjectile() {
        while (true) {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z + movementSpeed);
            yield return null;
        }
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Tank") collision.transform.parent.GetComponent<TankGame_Tank>().explode();
        if (collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Tank") Destroy(trajectory);
    }
}
