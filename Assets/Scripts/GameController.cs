using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] Player player;
    
    public static GameController Instance;
    

    void Awake()
    {
        Instance = this;
    }

    //TODO Split to PlayerFactory
    public void SetRoles(Role role)
    {
        player.SetRole(role);
    }
    
    public void StartGame()
    {
        Debug.Log("Game Started!");
    }
}
