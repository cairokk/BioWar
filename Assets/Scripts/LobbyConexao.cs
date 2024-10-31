using UnityEngine;
using Mirror;

public class LobbyConexao : MonoBehaviour
{
    public NetworkManager networkManager;

    // Método para o botão Iniciar (Host)
    public void IniciarComoHost()
    {
        if (networkManager == null)
        {
            Debug.LogError("NetworkManager não está definido.");
            return;
        }

        Debug.Log("Iniciando como Host...");
        networkManager.StartHost();
    }

    // Método para o botão Conectar (Cliente)
    public void ConectarComoCliente()
    {
        if (networkManager == null)
        {
            Debug.LogError("NetworkManager não está definido.");
            return;
        }

        Debug.Log("Conectando como Cliente...");
        networkManager.StartClient();
    }

    // Método para parar a conexão
    public void Desconectar()
    {
        if (networkManager == null)
        {
            Debug.LogError("NetworkManager não está definido.");
            return;
        }

        Debug.Log("Desconectando...");
        if (networkManager.isNetworkActive)
        {
            networkManager.StopHost();
        }
    }
}
