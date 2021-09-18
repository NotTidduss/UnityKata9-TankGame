using UnityEngine;

public class TankGame_ProjectileTrajectory : MonoBehaviour
{
    public GameObject projectile;

    void Start() {
        projectile.GetComponent<TankGame_ProjectileDefault>().trajectory = this.gameObject;
        Instantiate(projectile, transform.position, Quaternion.identity, transform);
    } 
}
