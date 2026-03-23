using UnityEngine;

// Dòng này cực kỳ vi diệu: Nó sẽ thêm 1 nút bấm vào menu chuột phải của Unity!
[CreateAssetMenu(fileName = "NewGameConfig", menuName = "Data/Game Config")]
public class GameConfig : ScriptableObject
{
    // Định nghĩa các thông số cố định của game
    public float playerBaseSpeed = 5.5f;
    public int startingGold = 100;
    public string gameVersion = "1.0.0";
}