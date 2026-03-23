using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    // Cấu trúc Singleton cơ bản để đảm bảo chỉ có duy nhất 1 GameManager tồn tại
    public static GameManagerScript Instance;

    void Awake()
    {
        // Kiểm tra xem đã có GameManager nào tồn tại chưa
        if (Instance == null)
        {
            Instance = this;
            // Lệnh tối thượng: Không hủy diệt object này khi chuyển Scene!
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // Nếu lỡ có 2 cái GameManager thì hủy cái mới sinh ra
            Destroy(gameObject);
        }
    }

    void Start()
    {
        Debug.Log("GameManager đã sẵn sàng và sẽ bất tử qua các Scene!");
    }
}