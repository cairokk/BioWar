using UnityEngine.SceneManagement;
using UnityEngine;
using Mirror;

public class MenuInicial : MonoBehaviour
{
    public NetworkManager networkManager;

    void Start()
    {
        // Usando o singleton do NetworkManager
        networkManager = NetworkManager.singleton;

        if (networkManager == null)
        {
            Debug.LogError("NetworkManager não encontrado na cena.");
        }
    }
    public void CriarPartida()
    {
        // Carregar a cena do jogo (substitua "NomeDaCenaDoJogo" pelo nome real da sua cena)
        if (networkManager == null)
        {
            Debug.LogError("NetworkManager não está definido.");
            return;
        }

        Debug.Log("Criando Partida como Host...");
        networkManager.StartHost();
        SceneManager.LoadScene("Lobby"); 
    }

    public void EntrarNaPartida(){
        if (networkManager == null)
        {
            Debug.LogError("NetworkManager não está definido.");
            return;
        }

        Debug.Log("Conectando como Cliente...");
        networkManager.StartClient();
        SceneManager.LoadScene("Lobby");
    }
    public void SairDoJogo()
    {
        // Fecha o jogo; funciona em build (não no editor da Unity)
        Debug.Log("Saindo do Jogo...");
        Application.Quit();
    }
}
