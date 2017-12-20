using System;
using System.Collections.Generic;
using System.Text;

namespace api_test
{
    public class Player
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class Team
    {
        public string ID { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
    }

    public class GamesPlayed
    {
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class TackleSolo
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class TackleTotal
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class TackleAst
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Sacks
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class SackYds
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Safeties
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class TacklesForLoss
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Interceptions
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class IntTD
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class IntYds
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class IntAverage
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class IntLng
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassesDefended
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Stuffs
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class StuffYds
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KB
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Fumbles
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FumLost
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FumForced
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FumOwnRec
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FumOppRec
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FumRecYds
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FumTotalRec
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FumTD
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KrRet
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KrYds
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KrAvg
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KrLng
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KrTD
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Kr20Plus
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Kr40Plus
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KrFC
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KrFum
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PrRet
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PrYds
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PrAvg
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PrLng
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PrTD
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Pr20Plus
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Pr40Plus
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PrFC
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PrFum
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Stats
    {
        public GamesPlayed GamesPlayed { get; set; }
        public TackleSolo TackleSolo { get; set; }
        public TackleTotal TackleTotal { get; set; }
        public TackleAst TackleAst { get; set; }
        public Sacks Sacks { get; set; }
        public SackYds SackYds { get; set; }
        public Safeties Safeties { get; set; }
        public TacklesForLoss TacklesForLoss { get; set; }
        public Interceptions Interceptions { get; set; }
        public IntTD IntTD { get; set; }
        public IntYds IntYds { get; set; }
        public IntAverage IntAverage { get; set; }
        public IntLng IntLng { get; set; }
        public PassesDefended PassesDefended { get; set; }
        public Stuffs Stuffs { get; set; }
        public StuffYds StuffYds { get; set; }
        public KB KB { get; set; }
        public Fumbles Fumbles { get; set; }
        public FumLost FumLost { get; set; }
        public FumForced FumForced { get; set; }
        public FumOwnRec FumOwnRec { get; set; }
        public FumOppRec FumOppRec { get; set; }
        public FumRecYds FumRecYds { get; set; }
        public FumTotalRec FumTotalRec { get; set; }
        public FumTD FumTD { get; set; }
        public KrRet KrRet { get; set; }
        public KrYds KrYds { get; set; }
        public KrAvg KrAvg { get; set; }
        public KrLng KrLng { get; set; }
        public KrTD KrTD { get; set; }
        public Kr20Plus Kr20Plus { get; set; }
        public Kr40Plus Kr40Plus { get; set; }
        public KrFC KrFC { get; set; }
        public KrFum KrFum { get; set; }
        public PrRet PrRet { get; set; }
        public PrYds PrYds { get; set; }
        public PrAvg PrAvg { get; set; }
        public PrLng PrLng { get; set; }
        public PrTD PrTD { get; set; }
        public Pr20Plus Pr20Plus { get; set; }
        public Pr40Plus Pr40Plus { get; set; }
        public PrFC PrFC { get; set; }
        public PrFum PrFum { get; set; }
    }

    public class PlayerStatsEntry
    {
        public Player player { get; set; }
        public Team team { get; set; }
        public Stats stats { get; set; }
    }

    public class PlayerStats
    {
        public string lastUpdatedOn { get; set; }
        public List<PlayerStatsEntry> playerstatsentry { get; set; }
    }

    public class CumulativePlayerStats : IFeedRoot
    {
        public PlayerStats PlayerStats { get; set; }
    }
}
