using UnityEngine;

public class TankGame_Tank : MonoBehaviour
{
    [Header("Tank Settings")]
    [SerializeField] private float movementSpeed = 0.05f;
    [SerializeField] private float turnSpeed = 1f;
    [SerializeField] private float barrelTurnSpeed = 1f;

    [Header("Tank References")]
    [SerializeField] private GameObject tankBarrel;
    [SerializeField] private GameObject tankProjectileSpawn;
    [SerializeField] private GameObject tankProjectileTrajectory;
    [SerializeField] private GameObject tankProjectile;
    [SerializeField] private GameObject tankExplosion;

    void Start() => tankProjectileTrajectory.GetComponent<TankGame_ProjectileTrajectory>().projectile = tankProjectile;

    #region movement
    public void move(float movement) => transform.Translate(0,0,movement);
    public void moveForward() => move(movementSpeed);
    public void moveBackward() => move(-movementSpeed);

    public void turn(float rotation) => transform.Rotate(0,rotation,0);
    public void turnLeft() => turn(turnSpeed);
    public void turnRight() => turn(-turnSpeed);

    public void turnBarrel(float barrelRotation) => tankBarrel.transform.Rotate(0,barrelRotation,0);
    public void turnBarrelLeft() => turnBarrel(barrelTurnSpeed);
    public void turnBarrelRight() => turnBarrel(-barrelTurnSpeed);
    #endregion
    #region gameplay
    public void shoot() => Instantiate(tankProjectileTrajectory, tankProjectileSpawn.transform.position, tankProjectileSpawn.transform.rotation);
    public void explode() {
        GameObject.Find("Master").GetComponent<TankGame_Master>().setGameOver();
        Instantiate(tankExplosion, transform);
    }
    #endregion
}
