using UnityEngine;

public class JsonManager : MonoBehaviour
{
    // Tạo một đối tượng từ class PlayerData vừa viết
    public PlayerData myData;

    void Start()
    {
        // Gán dữ liệu mặc định khi mới vào
        myData = new PlayerData();
        myData.playerName = "Siêu Nhân Vàng";
        myData.level = 10;
        myData.health = 100.5f;
    }

    // Hàm gắn vào nút Save
    public void SaveDataToJson()
    {
        // 1. Dùng phép thuật JsonUtility biến cái class thành 1 đoạn text (chuỗi)
        string jsonString = JsonUtility.ToJson(myData);

        Debug.Log("Dữ liệu sau khi đóng gói thành JSON: \n" + jsonString);

        // 2. Lưu cái chuỗi đó vào PlayerPrefs (hoặc ghi ra file ở Lab 6)
        PlayerPrefs.SetString("MySaveData", jsonString);
        PlayerPrefs.Save();
    }

    // Hàm gắn vào nút Load
    public void LoadDataFromJson()
    {
        // 1. Lấy chuỗi JSON từ PlayerPrefs ra
        string jsonString = PlayerPrefs.GetString("MySaveData", "");

        if (jsonString != "")
        {
            // 2. Dùng phép thuật FromJson để giải nén chuỗi text đó ngược lại thành Class PlayerData
            myData = JsonUtility.FromJson<PlayerData>(jsonString);

            Debug.Log($"Đã giải nén dữ liệu! Tên: {myData.playerName}, Level: {myData.level}, Máu: {myData.health}");
        }
        else
        {
            Debug.Log("Chưa có file save nào cả!");
        }
    }
}