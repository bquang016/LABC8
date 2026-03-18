using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Biến này dùng để chứa cái khuôn (Prefab) quái vật mà ta muốn đúc ra
    public GameObject enemyPrefab;

    void Update()
    {
        // Kiểm tra xem người chơi có bấm phím Space không
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Triệu hồi (Instantiate) quái vật tại vị trí của cục Spawner
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        }
    }
}