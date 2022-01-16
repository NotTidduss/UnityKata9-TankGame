using UnityEngine;

public class PlayerPrefsX : MonoBehaviour
{
    public static bool GetBool(string playerPrefKey) => PlayerPrefs.GetInt(playerPrefKey) == 1;
    public static void SetBool(string playerPrefKey, bool playerPrefValue) => PlayerPrefs.SetInt(playerPrefKey, playerPrefValue ? 1 : 0);
}
