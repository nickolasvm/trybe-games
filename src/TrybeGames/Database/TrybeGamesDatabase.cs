namespace TrybeGames;

public class TrybeGamesDatabase
{
    public List<Game> Games = new List<Game>();

    public List<GameStudio> GameStudios = new List<GameStudio>();

    public List<Player> Players = new List<Player>();

    public List<Game> GetGamesDevelopedBy(GameStudio gameStudio)
    {
        var gamesByStudio =
            from game in Games
            where game.DeveloperStudio == gameStudio.Id
            select game;

        return gamesByStudio.ToList();
    }

    public List<Game> GetGamesPlayedBy(Player player)
    {
        var gamesByPlayer =
            from game in Games
            from p in game.Players
            where p == player.Id
            select game;

        return gamesByPlayer.ToList();
    }

    public List<Game> GetGamesOwnedBy(Player playerEntry)
    {
        var gamesByPlayer =
            from game in Games
            from p in game.Players
            where p == playerEntry.Id
            select game;

        return gamesByPlayer.ToList();
    }


    // 7. Crie a funcionalidade de buscar todos os jogos junto do nome do estúdio desenvolvedor
    public List<GameWithStudio> GetGamesWithStudio()
    {
        // Implementar
        throw new NotImplementedException();
    }

    // 8. Crie a funcionalidade de buscar todos os diferentes Tipos de jogos dentre os jogos cadastrados
    public List<GameType> GetGameTypes()
    {
        // Implementar
        throw new NotImplementedException();
    }

    // 9. Crie a funcionalidade de buscar todos os estúdios de jogos junto dos seus jogos desenvolvidos com suas pessoas jogadoras
    public List<StudioGamesPlayers> GetStudiosWithGamesAndPlayers()
    {
        // Implementar
        throw new NotImplementedException();
    }

}
