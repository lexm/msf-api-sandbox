using System;
using System.Collections.Generic;
using System.Text;

namespace api_test
{

    public class Wins
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Losses
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Ties
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class OTWins
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class OTLosses
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class WinPct
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class TeamStandingStats
    {
        public GamesPlayed GamesPlayed { get; set; }
        public PassAttempts PassAttempts { get; set; }
        public PassCompletions PassCompletions { get; set; }
        public PassPct PassPct { get; set; }
        public PassGrossYards PassGrossYards { get; set; }
        public PassNetYards PassNetYards { get; set; }
        public PassAvg PassAvg { get; set; }
        public PassYardsPerAtt PassYardsPerAtt { get; set; }
        public PassTD PassTD { get; set; }
        public PassTDPct PassTDPct { get; set; }
        public PassInt PassInt { get; set; }
        public PassIntPct PassIntPct { get; set; }
        public PassLng PassLng { get; set; }
        public Pass20Plus Pass20Plus { get; set; }
        public Pass40Plus Pass40Plus { get; set; }
        public PassSacks PassSacks { get; set; }
        public PassSackY PassSackY { get; set; }
        public QBRating QBRating { get; set; }
        public RushAttempts RushAttempts { get; set; }
        public RushYards RushYards { get; set; }
        public RushAverage RushAverage { get; set; }
        public RushTD RushTD { get; set; }
        public RushLng RushLng { get; set; }
        public Rush20Plus Rush20Plus { get; set; }
        public Rush40Plus Rush40Plus { get; set; }
        public RushFumbles RushFumbles { get; set; }
        public Receptions Receptions { get; set; }
        public RecYards RecYards { get; set; }
        public RecAverage RecAverage { get; set; }
        public RecTD RecTD { get; set; }
        public RecLng RecLng { get; set; }
        public Rec20Plus Rec20Plus { get; set; }
        public Rec40Plus Rec40Plus { get; set; }
        public RecFumbles RecFumbles { get; set; }
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
        public FgBlk FgBlk { get; set; }
        public FgMade FgMade { get; set; }
        public FgAtt FgAtt { get; set; }
        public FgPct FgPct { get; set; }
        public FgMade119 FgMade1_19 { get; set; }
        public FgAtt119 FgAtt1_19 { get; set; }
        public Fg119Pct Fg1_19Pct { get; set; }
        public FgMade2029 FgMade20_29 { get; set; }
        public FgAtt2029 FgAtt20_29 { get; set; }
        public Fg2029Pct Fg20_29Pct { get; set; }
        public FgMade3039 FgMade30_39 { get; set; }
        public FgAtt3039 FgAtt30_39 { get; set; }
        public Fg3039Pct Fg30_39Pct { get; set; }
        public FgMade4049 FgMade40_49 { get; set; }
        public FgAtt4049 FgAtt40_49 { get; set; }
        public Fg4049Pct Fg40_49Pct { get; set; }
        public FgMade50Plus FgMade50Plus { get; set; }
        public FgAtt50Plus FgAtt50Plus { get; set; }
        public Fg50PlusPct Fg50PlusPct { get; set; }
        public FgLng FgLng { get; set; }
        public XpBlk XpBlk { get; set; }
        public XpMade XpMade { get; set; }
        public XpAtt XpAtt { get; set; }
        public XpPct XpPct { get; set; }
        public FgAndXpPts FgAndXpPts { get; set; }
        public Kickoffs Kickoffs { get; set; }
        public KoYds KoYds { get; set; }
        public KoOOB KoOOB { get; set; }
        public KoAvg KoAvg { get; set; }
        public KoTB KoTB { get; set; }
        public KoPct KoPct { get; set; }
        public KoRet KoRet { get; set; }
        public KoRetYds KoRetYds { get; set; }
        public KoRetAvgYds KoRetAvgYds { get; set; }
        public KoTD KoTD { get; set; }
        public KoOS KoOS { get; set; }
        public KoOSR KoOSR { get; set; }
        public Punts Punts { get; set; }
        public PuntYds PuntYds { get; set; }
        public PuntNetYds PuntNetYds { get; set; }
        public PuntLng PuntLng { get; set; }
        public PuntAvg PuntAvg { get; set; }
        public PuntNetAvg PuntNetAvg { get; set; }
        public PuntBlk PuntBlk { get; set; }
        public PuntOOB PuntOOB { get; set; }
        public PuntDown PuntDown { get; set; }
        public PuntIn20 PuntIn20 { get; set; }
        public PuntIn20Pct PuntIn20Pct { get; set; }
        public PuntTB PuntTB { get; set; }
        public PuntTBPct PuntTBPct { get; set; }
        public PuntFC PuntFC { get; set; }
        public PuntRet PuntRet { get; set; }
        public PuntRetYds PuntRetYds { get; set; }
        public PuntRetAvg PuntRetAvg { get; set; }
        public FirstDownsTotal FirstDownsTotal { get; set; }
        public FirstDownsPass FirstDownsPass { get; set; }
        public FirstDownsRush FirstDownsRush { get; set; }
        public FirstDownsPenalty FirstDownsPenalty { get; set; }
        public ThirdDowns ThirdDowns { get; set; }
        public ThirdDownsAtt ThirdDownsAtt { get; set; }
        public ThirdDownsPct ThirdDownsPct { get; set; }
        public FourthDowns FourthDowns { get; set; }
        public FourthDownsAtt FourthDownsAtt { get; set; }
        public FourthDownsPct FourthDownsPct { get; set; }
        public Penalties Penalties { get; set; }
        public PenaltyYds PenaltyYds { get; set; }
        public OffensePlays OffensePlays { get; set; }
        public OffenseYds OffenseYds { get; set; }
        public OffenseAvgYds OffenseAvgYds { get; set; }
        public TotalTD TotalTD { get; set; }
        public Wins Wins { get; set; }
        public Losses Losses { get; set; }
        public Ties Ties { get; set; }
        public OTWins OTWins { get; set; }
        public OTLosses OTLosses { get; set; }
        public WinPct WinPct { get; set; }
        public PointsFor PointsFor { get; set; }
        public PointsAgainst PointsAgainst { get; set; }
        public PointDifferential PointDifferential { get; set; }
    }

    public class TeamStandingsEntry
    {
        public Team team { get; set; }
        public string rank { get; set; }
        public TeamStandingStats stats { get; set; }
    }

    public class TeamStandings
    {
        public string lastUpdatedOn { get; set; }
        public List<TeamStandingsEntry> teamstandingsentry { get; set; }
    }

    public class OverallTeamStandings : IFeedRoot
    {
        public TeamStandings overallteamstandings { get; set; }
    }
}
