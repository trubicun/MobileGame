using UnityEngine;

public class RoleSelectionMenu : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Awake");
        transform.GetChild(0).gameObject.SetActive(true);
    }

    //TODO: Make menu more decoupling
    //TODO: Start Game from other place
    public void SelectElectronics()
    {
        var role = RoleFactory.CreateRole(RoleType.Electronics);
        
        GameController.Instance.SetRoles(role);
        GameController.Instance.StartGame();
        
        Quit();
    }

    void Quit()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }
}
