using UnityEngine;

public class TankGame_Tank : MonoBehaviour
{
    [Header("Tank References")]
    [SerializeField] private GameObject tankBarrel;
    [SerializeField] private GameObject tankProjectileSpawn;
    [SerializeField] private GameObject tankProjectileTrajectory;
    [SerializeField] private GameObject tankProjectile;
    [SerializeField] private GameObject tankExplosion;


    //* private vars
    private TankGame_System sys;


    public void initialize(TankGame_System sysRef) {
        sys = sysRef;

        tankProjectileTrajectory.GetComponent<TankGame_ProjectileTrajectory>().projectile = tankProjectile;
    }


#region Movement
    public void move(float movement) => transform.Translate(0,0,movement);
    public void moveForward() => move(sys.movementSpeed);
    public void moveBackward() => move(-sys.movementSpeed);

    public void turn(float rotation) => transform.Rotate(0,rotation,0);
    public void turnLeft() => turn(sys.turnSpeed);
    public void turnRight() => turn(-sys.turnSpeed);

    public void turnBarrel(float barrelRotation) => tankBarrel.transform.Rotate(0,barrelRotation,0);
    public void turnBarrelLeft() => turnBarrel(sys.barrelTurnSpeed);
    public void turnBarrelRight() => turnBarrel(-sys.barrelTurnSpeed);
#endregion

#region Gameplay
    public void shoot() => Instantiate(tankProjectileTrajectory, tankProjectileSpawn.transform.position, tankProjectileSpawn.transform.rotation);
    public void explode() {
        PlayerPrefsX.SetBool("tankGame_gameOver", true);
        Instantiate(tankExplosion, transform);
    }
#endregion
}
