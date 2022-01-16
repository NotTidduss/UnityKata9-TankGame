using UnityEngine;
using UnityEngine.SceneManagement;

public class TankGame_System : MonoBehaviour
{
    [Header("PlayerPrefs Master")]
    [SerializeField] private TankGame_PlayerPrefsMaster playerPrefsMaster;


    [Header("Tank Preferences")]
    public float movementSpeed = 0.01f;
    public float turnSpeed = 0.25f;
    public float barrelTurnSpeed = 0.5f;


    public void resetPlayerPrefs() => playerPrefsMaster.resetPlayerPrefs();    


#region Keybindings
    [Header("Input Preferences")]
    public KeyCode playerMoveForward = KeyCode.W;
    public KeyCode playerMoveBackward = KeyCode.S;
    public KeyCode playerTurnLeft = KeyCode.A;
    public KeyCode playerTurnRight = KeyCode.D;
    public KeyCode playerTurnBarrelLeft = KeyCode.LeftArrow;
    public KeyCode playerTurnBarrelRight = KeyCode.RightArrow;
    public KeyCode playerShoot = KeyCode.Space;
    public KeyCode resetGame = KeyCode.R;
#endregion

#region Scene Management
    [Header("Scene Names")]
    public string tankGameSceneName = "1x_TankGame";

    public void loadGameScene() => SceneManager.LoadScene(tankGameSceneName);
#endregion
}
