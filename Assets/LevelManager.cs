using UnityEngine;

public class LevelManager : MonoSingleton<LevelManager> {

    private string message = "No message";

    
    public override void Init() {
        message = "Hello LevelManager";
    }

    public void Print() {
        Debug.Log(message);
    }
    
}
