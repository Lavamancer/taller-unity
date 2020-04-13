using UnityEngine;

public class GameManager : MonoBehaviour {
    
    private int score = 0;


    private static GameManager _instance;
    public static GameManager Instance {
        get {
            if (_instance == null) {
                GameObject gameObject = new GameObject("GameManager");
                gameObject.AddComponent<GameManager>();
            }
            return _instance;
        }
    }
    
    private void Awake() {
        _instance = this;
    }

    public void AddScore(int score) {
        this.score += score;
        Debug.Log("Score: " + this.score);
    }

}
