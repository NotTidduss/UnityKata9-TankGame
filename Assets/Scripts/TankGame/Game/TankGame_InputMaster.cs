using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankGame_InputMaster : MonoBehaviour
{
    //* private vars
    private TankGame_System sys;
    private TankGame_Tank playerTank;


    public void initialize(TankGame_System sysRef, TankGame_Tank playerTankRef) {
        sys = sysRef;
        playerTank = playerTankRef;

        StartCoroutine(CheckForKeyPress());
    }


    IEnumerator CheckForKeyPress() {
        for (;;) {
            if (Input.GetKey(sys.playerMoveForward)) playerTank.moveForward();
            if (Input.GetKey(sys.playerMoveBackward)) playerTank.moveBackward();
            if (Input.GetKey(sys.playerTurnLeft)) playerTank.turnLeft();
            if (Input.GetKey(sys.playerTurnRight)) playerTank.turnRight();
            if (Input.GetKey(sys.playerTurnBarrelLeft)) playerTank.turnBarrelLeft();
            if (Input.GetKey(sys.playerTurnBarrelRight)) playerTank.turnBarrelRight();
            if (Input.GetKeyUp(sys.playerShoot)) playerTank.shoot();
            yield return null;
        }
    }
}
