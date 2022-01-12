using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] PlayerRoleFactory roleFactory;
    
    //TODO: Use Injection instead of singleton
    public static GameController Instance;
    
    void Awake()
    {
        Instance = this;
    }

    //TODO Split to PlayerFactory
    public void SetRoles(RoleType roleType)
    {
        var role = roleFactory.CreateRole(roleType, player.transform);
        player.SetRole(role);
    }
    
    public void StartGame()
    {
        Debug.Log("Game Started!");
    }
}
