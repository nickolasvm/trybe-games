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

    public List<GameWithStudio> GetGamesWithStudio()
    {
        var GamesWithStudio =
            from game in Games
            from studio in GameStudios
            where game.DeveloperStudio == studio.Id
            select new GameWithStudio { GameName = game.Name, StudioName = studio.Name, NumberOfPlayers = game.Players.Count };

        return GamesWithStudio.ToList();

    }

    public List<GameType> GetGameTypes()
    {
        var gamesByType = Games.GroupBy(game => game.GameType);
        List<GameType> gameTypes = new();

        foreach (var game in gamesByType)
        {
            gameTypes.Add(game.Key);
        }

        return gameTypes;
    }

    // 9. Crie a funcionalidade de buscar todos os estúdios de jogos junto dos seus jogos desenvolvidos com suas pessoas jogadoras
    public List<StudioGamesPlayers> GetStudiosWithGamesAndPlayers()
    {
        // Implementar
        throw new NotImplementedException();
    }

}
