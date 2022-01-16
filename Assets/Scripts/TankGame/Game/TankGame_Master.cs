using System.Collections;
using UnityEngine;

public class TankGame_Master : MonoBehaviour
{
    [Header("Scene References")]
    [SerializeField] private TankGame_System sys;
    [SerializeField] private TankGame_InputMaster inputMaster;
    [SerializeField] private TankGame_Tank playerTank; 
    [SerializeField] private GameObject enemyTank; 


    void Start() 
    {
        sys.resetPlayerPrefs();
        inputMaster.initialize(sys, playerTank);
        playerTank.initialize(sys);

        Instantiate(enemyTank, new Vector3(Random.Range(2,15), 0, Random.Range(2,15)), Quaternion.identity);
    } 


    IEnumerator CheckGameOver() 
    {
        for (;;)
        {
            if (PlayerPrefsX.GetBool("tankGame_gameOver")) {
                Debug.Log("GAME OVER");
            }
            yield return new WaitForSeconds(3f);
        }
    }
}
