using UnityEngine;

public class GameController : MonoBehaviour
{
    void Start()
    {
        // Vừa vào GameScene là lôi biến static ra đọc luôn
        Debug.Log("Dữ liệu nhận được từ Menu là: " + StaticData.score);
    }
}