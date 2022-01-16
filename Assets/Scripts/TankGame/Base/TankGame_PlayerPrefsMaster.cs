using UnityEngine;

public class TankGame_PlayerPrefsMaster : MonoBehaviour
{
    public void resetPlayerPrefs() {
        // BOOL tankGame_gameOver - Indicates if the game is, in fact, over. TRUE means it's over.
        PlayerPrefsX.SetBool("tankGame_gameOver", false);
    }
}
