using Mirror;
using UnityEngine;

public class LobbyManager : NetworkManager
{
    public override void OnServerAddPlayer(NetworkConnectionToClient conn)
    {
        // Cria um novo jogador ao conectar
        GameObject player = Instantiate(playerPrefab);
        NetworkServer.AddPlayerForConnection(conn, player);

        // Atribui o time ao jogador
        int team = numPlayers % 2;  // Alterna os times (0 ou 1)
        player.GetComponent<Player>().SetTeam(team);

        Debug.Log("Jogador adicionado e atribuído ao Time " + (team == 0 ? "A" : "B"));
    }

    public override void OnClientConnect()
    {
        base.OnClientConnect();
        Debug.Log("Conectado ao servidor.");
    }
}

public class Player : NetworkBehaviour
{
    [SyncVar]
    public int team; // Variável sincronizada para o time

    public void SetTeam(int team)
    {
        this.team = team;
        Debug.Log("Time atribuído: " + (team == 0 ? "A" : "B"));
    }
}
