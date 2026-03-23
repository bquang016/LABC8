using UnityEngine;
using TMPro; // Cần thư viện này để tương tác với TextMeshPro

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Biến chứa UI Text hiển thị điểm
    private int currentScore = 0;

    void Start()
    {
        // Vừa vào game là tự động lấy điểm cũ ra xem
        LoadHighScore();
    }

    public void AddScore()
    {
        currentScore += 10;
        UpdateUI();
    }

    public void SaveHighScore()
    {
        // Lưu điểm hiện tại vào bộ nhớ máy tính với chiếc chìa khóa tên là "HighScore"
        PlayerPrefs.SetInt("HighScore", currentScore);

        // Lệnh này ép Unity ghi dữ liệu vào ổ cứng ngay lập tức
        PlayerPrefs.Save();

        Debug.Log("Đã lưu điểm thành công: " + currentScore);
    }

    public void LoadHighScore()
    {
        // Tìm trong bộ nhớ xem có cái khóa "HighScore" không.
        // Nếu có thì lấy giá trị đó ra, nếu không có (chơi lần đầu) thì trả về giá trị mặc định là 0.
        currentScore = PlayerPrefs.GetInt("HighScore", 0);
        UpdateUI();
        Debug.Log("Đã tải điểm: " + currentScore);
    }

    public void ResetData()
    {
        // Xóa sạch dữ liệu của khóa "HighScore"
        PlayerPrefs.DeleteKey("HighScore");
        currentScore = 0;
        UpdateUI();
        Debug.Log("Đã xóa dữ liệu điểm!");
    }

    private void UpdateUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "High Score: " + currentScore;
        }
    }
}