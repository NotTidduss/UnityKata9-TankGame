using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TankGame_Master : MonoBehaviour
{
    [Header("Input Settings")]
    [SerializeField] private KeyCode playerMoveForward = KeyCode.W;
    [SerializeField] private KeyCode playerMoveBackward = KeyCode.S;
    [SerializeField] private KeyCode playerTurnLeft = KeyCode.A;
    [SerializeField] private KeyCode playerTurnRight = KeyCode.D;
    [SerializeField] private KeyCode playerTurnBarrelLeft = KeyCode.LeftArrow;
    [SerializeField] private KeyCode playerTurnBarrelRight = KeyCode.RightArrow;
    [SerializeField] private KeyCode playerShoot = KeyCode.Space;
    [SerializeField] private KeyCode reset = KeyCode.R;

    [Header("Scene References")]
    [SerializeField] private TankGame_Tank playerTank; 
    [SerializeField] private GameObject arena; 
    [SerializeField] private GameObject enemyTank; 

    private bool isGameOver = false;

    void Start() {
        Instantiate(enemyTank, new Vector3(Random.Range(2,15), 0, Random.Range(2,15)), Quaternion.identity);

        StartCoroutine("checkPlayerInput");
    } 

    IEnumerator checkPlayerInput() {
        while (true) {
            // Regular PlayerInput
            if (Input.GetKey(playerMoveForward)) playerTank.moveForward();
            if (Input.GetKey(playerMoveBackward)) playerTank.moveBackward();
            if (Input.GetKey(playerTurnLeft)) playerTank.turnLeft();
            if (Input.GetKey(playerTurnRight)) playerTank.turnRight();
            if (Input.GetKey(playerTurnBarrelLeft)) playerTank.turnBarrelLeft();
            if (Input.GetKey(playerTurnBarrelRight)) playerTank.turnBarrelRight();
            if (Input.GetKeyUp(playerShoot)) playerTank.shoot();

            // Conditional PlayerInput
            if (isGameOver && Input.GetKey(reset)) SceneManager.LoadScene("1_TankGame");

            yield return null;
        }
    }

    public void setGameOver() => isGameOver = true;
}
