using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    void Update()
    {
        // Bấm phím Enter để gán dữ liệu và chuyển Scene
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StaticData.score = 999; // Gán dữ liệu vào biến static
            Debug.Log("Đã lưu điểm ở Menu: " + StaticData.score);
            SceneManager.LoadScene("GameScene"); // Chuyển sang GameScene
        }
    }
}