using Core.Games;
using Core.Player;
using JetBrains.Annotations;
using UnityEngine;

namespace Teams.Colossus
{
    [UsedImplicitly]
    public class ExampleTeam : Team
    {
        public TeamPlayer GetPlayerOne() => new Goalkeeper();

        public TeamPlayer GetPlayerTwo() => new Mid();

        public TeamPlayer GetPlayerThree() => new Offensive();

        public string TeamEmblem => "Colossus_shield";

        public Color PrimaryColor => new Color(0.6f, 0.6f, 1f);

        public string GetName() => "Colosus F.C.";
        
        
        public string TeamShield { get; }

    }
}