using UnityEngine;

public class PlayerSetup : MonoBehaviour
{
    // Tạo 1 khe cắm để nhét cái file ScriptableObject vào
    public GameConfig myConfig;

    void Start()
    {
        // Đọc dữ liệu trực tiếp từ file Asset
        if (myConfig != null)
        {
            Debug.Log("Phiên bản game: " + myConfig.gameVersion);
            Debug.Log("Tiền khởi điểm: " + myConfig.startingGold);
        }
        else
        {
            Debug.LogWarning("Chưa gắn file Config vào đây!");
        }
    }
}