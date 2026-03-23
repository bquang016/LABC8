using UnityEngine;
using System.IO; // BẮT BUỘC phải có dòng này để can thiệp vào File hệ thống

public class FileSaveManager : MonoBehaviour
{
    // Dùng lại khuôn mẫu PlayerData từ Lab 4
    public PlayerData myData;

    // Biến lưu đường dẫn tới file save
    private string saveFilePath;

    void Start()
    {
        // Cấu hình đường dẫn. Unity sẽ tự tìm thư mục an toàn nhất trên máy tính/điện thoại của bạn.
        saveFilePath = Application.persistentDataPath + "/savegame.json";

        // In ra Console để tí nữa bạn biết đường mò vào ổ C:\ xem file thực tế
        Debug.Log("Đường dẫn file save nằm ở: " + saveFilePath);

        // Tạo dữ liệu mẫu để test
        myData = new PlayerData();
        myData.playerName = "Hero Quang";
        myData.level = 50;
        myData.health = 999.9f;
    }

    public void SaveGameToFile()
    {
        // 1. Đóng gói dữ liệu thành chuỗi JSON
        string json = JsonUtility.ToJson(myData);

        // 2. Dùng System.IO để ghi toàn bộ chuỗi đó vào ổ cứng
        File.WriteAllText(saveFilePath, json);

        Debug.Log("Đã tạo và ghi file save thành công!");
    }

    public void LoadGameFromFile()
    {
        // Kiểm tra xem file có tồn tại trên ổ cứng không (kẻo lỗi game)
        if (File.Exists(saveFilePath))
        {
            // 1. Đọc toàn bộ chữ trong file đó ra
            string json = File.ReadAllText(saveFilePath);

            // 2. Giải nén chuỗi chữ đó ngược lại thành dữ liệu game
            myData = JsonUtility.FromJson<PlayerData>(json);

            Debug.Log($"Đã Load File! Tên: {myData.playerName}, Level: {myData.level}");
        }
        else
        {
            Debug.LogWarning("Không tìm thấy file save nào ở đường dẫn trên!");
        }
    }
}