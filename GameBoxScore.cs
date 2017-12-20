using System;
using System.Collections.Generic;
using System.Text;

namespace api_test
{

    public class ScoringPlay
    {
        public string time { get; set; }
        public string teamAbbreviation { get; set; }
        public string playDescription { get; set; }
    }

    public class Scoring
    {
        public List<ScoringPlay> scoringPlay { get; set; }
    }

    public class Quarter
    {
        public string number { get; set; }
        public string awayScore { get; set; }
        public string homeScore { get; set; }
        public Scoring scoring { get; set; }
    }

    public class QuarterTotals
    {
        public string awayScore { get; set; }
        public string homeScore { get; set; }
    }

    public class QuarterSummary
    {
        public List<Quarter> quarter { get; set; }
        public QuarterTotals quarterTotals { get; set; }
    }

    public class PassAttempts
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassCompletions
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassPct
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassGrossYards
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassNetYards
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassAvg
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassYardsPerAtt
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassTD
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassTDPct
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassInt
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassIntPct
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassLng
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Pass20Plus
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Pass40Plus
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassSacks
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassSackY
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class QBRating
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RushAttempts
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RushYards
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RushAverage
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RushTD
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RushLng
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Rush20Plus
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Rush40Plus
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RushFumbles
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Receptions
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RecYards
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RecAverage
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RecTD
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RecLng
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Rec20Plus
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Rec40Plus
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RecFumbles
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgBlk
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgMade
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgAtt
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgPct
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgMade50Plus
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgAtt50Plus
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Fg50PlusPct
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgLng
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class XpBlk
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class XpMade
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class XpAtt
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class XpPct
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgAndXpPts
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Kickoffs
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoYds
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoOOB
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoAvg
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoTB
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoPct
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoRet
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoRetYds
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoRetAvgYds
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoTD
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoOS
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoOSR
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Punts
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntYds
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntNetYds
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntLng
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntAvg
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntNetAvg
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntBlk
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntOOB
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntDown
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntIn20
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntIn20Pct
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntTB
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntTBPct
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntFC
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntRet
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntRetYds
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntRetAvg
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FirstDownsTotal
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FirstDownsPass
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FirstDownsRush
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FirstDownsPenalty
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class ThirdDowns
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class ThirdDownsAtt
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class ThirdDownsPct
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FourthDowns
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FourthDownsAtt
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FourthDownsPct
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Penalties
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PenaltyYds
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class OffensePlays
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class OffenseYds
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class OffenseAvgYds
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class TotalTD
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PointsFor
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PointsAgainst
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PointDifferential
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class AwayTeamStats
    {
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
        public PointsFor PointsFor { get; set; }
        public PointsAgainst PointsAgainst { get; set; }
        public PointDifferential PointDifferential { get; set; }
    }

    public class TackleSolo2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class TackleTotal2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class TackleAst2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Sacks2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class SackYds2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Safeties2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class TacklesForLoss2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Interceptions2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class IntTD2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class IntYds2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class IntAverage2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class IntLng2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassesDefended2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Stuffs2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class StuffYds2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KB2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Fumbles2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FumLost2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FumForced2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FumOwnRec2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FumOppRec2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FumRecYds2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FumTotalRec2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FumTD2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KrRet2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KrYds2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KrAvg2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KrLng2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KrTD2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Kr20Plus2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Kr40Plus2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KrFC2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KrFum2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PrRet2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PrYds2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PrAvg2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PrLng2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PrTD2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Pr20Plus2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Pr40Plus2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PrFC2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PrFum2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Punts2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntYds2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntNetYds2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntLng2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntAvg2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntNetAvg2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntBlk2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntOOB2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntDown2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntIn202
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntIn20Pct2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntTB2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntTBPct2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntFC2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntRet2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntRetYds2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntRetAvg2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgBlk2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgMade2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgAtt2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgPct2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgMade119
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgAtt119
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Fg119Pct
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgMade2029
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgAtt2029
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Fg2029Pct
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgMade3039
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgAtt3039
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Fg3039Pct
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgMade4049
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgAtt4049
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Fg4049Pct
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgMade50Plus2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgAtt50Plus2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Fg50PlusPct2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgLng2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class XpBlk2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class XpMade2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class XpAtt2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class XpPct2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgAndXpPts2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Kickoffs2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoYds2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoOOB2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoAvg2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoTB2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoPct2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoRet2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoRetYds2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoRetAvgYds2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoTD2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoOS2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoOSR2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassAttempts2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassCompletions2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassPct2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassYards
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassAvg2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassYardsPerAtt2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassTD2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassTDPct2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassInt2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassIntPct2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassLng2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Pass20Plus2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Pass40Plus2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassSacks2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassSackY2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class QBRating2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RushAttempts2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RushYards2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RushAverage2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RushTD2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RushLng2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Rush20Plus2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Rush40Plus2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RushFumbles2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Targets
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Receptions2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RecYards2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RecAverage2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RecTD2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RecLng2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Rec20Plus2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Rec40Plus2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RecFumbles2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PlayerEntry
    {
        public Player player { get; set; }
        public Stats stats { get; set; }
    }

    public class AwayPlayers
    {
        public List<PlayerEntry> playerEntry { get; set; }
    }

    public class AwayTeam2
    {
        public AwayTeamStats awayTeamStats { get; set; }
        public AwayPlayers awayPlayers { get; set; }
    }

    public class PassAttempts3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassCompletions3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassPct3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassGrossYards2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassNetYards2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassAvg3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassYardsPerAtt3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassTD3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassTDPct3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassInt3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassIntPct3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassLng3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Pass20Plus3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Pass40Plus3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassSacks3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassSackY3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class QBRating3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RushAttempts3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RushYards3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RushAverage3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RushTD3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RushLng3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Rush20Plus3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Rush40Plus3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RushFumbles3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Receptions3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RecYards3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RecAverage3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RecTD3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RecLng3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Rec20Plus3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Rec40Plus3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RecFumbles3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class TackleSolo3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class TackleTotal3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class TackleAst3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Sacks3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class SackYds3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Safeties3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class TacklesForLoss3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Interceptions3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class IntTD3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class IntYds3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class IntAverage3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class IntLng3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassesDefended3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Stuffs3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class StuffYds3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KB3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Fumbles3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FumLost3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FumForced3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FumOwnRec3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FumOppRec3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FumRecYds3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FumTotalRec3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FumTD3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KrRet3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KrYds3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KrAvg3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KrLng3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KrTD3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Kr20Plus3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Kr40Plus3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KrFC3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KrFum3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PrRet3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PrYds3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PrAvg3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PrLng3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PrTD3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Pr20Plus3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Pr40Plus3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PrFC3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PrFum3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgBlk3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgMade3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgAtt3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgPct3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgMade1192
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgAtt1192
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Fg119Pct2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgMade20292
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgAtt20292
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Fg2029Pct2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgMade30392
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgAtt30392
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Fg3039Pct2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgMade40492
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgAtt40492
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Fg4049Pct2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgMade50Plus3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgAtt50Plus3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Fg50PlusPct3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgLng3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class XpBlk3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class XpMade3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class XpAtt3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class XpPct3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgAndXpPts3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Kickoffs3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoYds3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoOOB3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoAvg3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoTB3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoPct3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoRet3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoRetYds3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoRetAvgYds3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoTD3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoOS3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoOSR3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Punts3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntYds3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntNetYds3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntLng3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntAvg3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntNetAvg3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntBlk3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntOOB3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntDown3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntIn203
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntIn20Pct3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntTB3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntTBPct3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntFC3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntRet3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntRetYds3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntRetAvg3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FirstDownsTotal2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FirstDownsPass2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FirstDownsRush2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FirstDownsPenalty2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class ThirdDowns2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class ThirdDownsAtt2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class ThirdDownsPct2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FourthDowns2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FourthDownsAtt2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FourthDownsPct2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Penalties2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PenaltyYds2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class OffensePlays2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class OffenseYds2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class OffenseAvgYds2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class TotalTD2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PointsFor2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PointsAgainst2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PointDifferential2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class HomeTeamStats
    {
        public PassAttempts3 PassAttempts { get; set; }
        public PassCompletions3 PassCompletions { get; set; }
        public PassPct3 PassPct { get; set; }
        public PassGrossYards2 PassGrossYards { get; set; }
        public PassNetYards2 PassNetYards { get; set; }
        public PassAvg3 PassAvg { get; set; }
        public PassYardsPerAtt3 PassYardsPerAtt { get; set; }
        public PassTD3 PassTD { get; set; }
        public PassTDPct3 PassTDPct { get; set; }
        public PassInt3 PassInt { get; set; }
        public PassIntPct3 PassIntPct { get; set; }
        public PassLng3 PassLng { get; set; }
        public Pass20Plus3 Pass20Plus { get; set; }
        public Pass40Plus3 Pass40Plus { get; set; }
        public PassSacks3 PassSacks { get; set; }
        public PassSackY3 PassSackY { get; set; }
        public QBRating3 QBRating { get; set; }
        public RushAttempts3 RushAttempts { get; set; }
        public RushYards3 RushYards { get; set; }
        public RushAverage3 RushAverage { get; set; }
        public RushTD3 RushTD { get; set; }
        public RushLng3 RushLng { get; set; }
        public Rush20Plus3 Rush20Plus { get; set; }
        public Rush40Plus3 Rush40Plus { get; set; }
        public RushFumbles3 RushFumbles { get; set; }
        public Receptions3 Receptions { get; set; }
        public RecYards3 RecYards { get; set; }
        public RecAverage3 RecAverage { get; set; }
        public RecTD3 RecTD { get; set; }
        public RecLng3 RecLng { get; set; }
        public Rec20Plus3 Rec20Plus { get; set; }
        public Rec40Plus3 Rec40Plus { get; set; }
        public RecFumbles3 RecFumbles { get; set; }
        public TackleSolo3 TackleSolo { get; set; }
        public TackleTotal3 TackleTotal { get; set; }
        public TackleAst3 TackleAst { get; set; }
        public Sacks3 Sacks { get; set; }
        public SackYds3 SackYds { get; set; }
        public Safeties3 Safeties { get; set; }
        public TacklesForLoss3 TacklesForLoss { get; set; }
        public Interceptions3 Interceptions { get; set; }
        public IntTD3 IntTD { get; set; }
        public IntYds3 IntYds { get; set; }
        public IntAverage3 IntAverage { get; set; }
        public IntLng3 IntLng { get; set; }
        public PassesDefended3 PassesDefended { get; set; }
        public Stuffs3 Stuffs { get; set; }
        public StuffYds3 StuffYds { get; set; }
        public KB3 KB { get; set; }
        public Fumbles3 Fumbles { get; set; }
        public FumLost3 FumLost { get; set; }
        public FumForced3 FumForced { get; set; }
        public FumOwnRec3 FumOwnRec { get; set; }
        public FumOppRec3 FumOppRec { get; set; }
        public FumRecYds3 FumRecYds { get; set; }
        public FumTotalRec3 FumTotalRec { get; set; }
        public FumTD3 FumTD { get; set; }
        public KrRet3 KrRet { get; set; }
        public KrYds3 KrYds { get; set; }
        public KrAvg3 KrAvg { get; set; }
        public KrLng3 KrLng { get; set; }
        public KrTD3 KrTD { get; set; }
        public Kr20Plus3 Kr20Plus { get; set; }
        public Kr40Plus3 Kr40Plus { get; set; }
        public KrFC3 KrFC { get; set; }
        public KrFum3 KrFum { get; set; }
        public PrRet3 PrRet { get; set; }
        public PrYds3 PrYds { get; set; }
        public PrAvg3 PrAvg { get; set; }
        public PrLng3 PrLng { get; set; }
        public PrTD3 PrTD { get; set; }
        public Pr20Plus3 Pr20Plus { get; set; }
        public Pr40Plus3 Pr40Plus { get; set; }
        public PrFC3 PrFC { get; set; }
        public PrFum3 PrFum { get; set; }
        public FgBlk3 FgBlk { get; set; }
        public FgMade3 FgMade { get; set; }
        public FgAtt3 FgAtt { get; set; }
        public FgPct3 FgPct { get; set; }
        public FgMade1192 FgMade1_19 { get; set; }
        public FgAtt1192 FgAtt1_19 { get; set; }
        public Fg119Pct2 Fg1_19Pct { get; set; }
        public FgMade20292 FgMade20_29 { get; set; }
        public FgAtt20292 FgAtt20_29 { get; set; }
        public Fg2029Pct2 Fg20_29Pct { get; set; }
        public FgMade30392 FgMade30_39 { get; set; }
        public FgAtt30392 FgAtt30_39 { get; set; }
        public Fg3039Pct2 Fg30_39Pct { get; set; }
        public FgMade40492 FgMade40_49 { get; set; }
        public FgAtt40492 FgAtt40_49 { get; set; }
        public Fg4049Pct2 Fg40_49Pct { get; set; }
        public FgMade50Plus3 FgMade50Plus { get; set; }
        public FgAtt50Plus3 FgAtt50Plus { get; set; }
        public Fg50PlusPct3 Fg50PlusPct { get; set; }
        public FgLng3 FgLng { get; set; }
        public XpBlk3 XpBlk { get; set; }
        public XpMade3 XpMade { get; set; }
        public XpAtt3 XpAtt { get; set; }
        public XpPct3 XpPct { get; set; }
        public FgAndXpPts3 FgAndXpPts { get; set; }
        public Kickoffs3 Kickoffs { get; set; }
        public KoYds3 KoYds { get; set; }
        public KoOOB3 KoOOB { get; set; }
        public KoAvg3 KoAvg { get; set; }
        public KoTB3 KoTB { get; set; }
        public KoPct3 KoPct { get; set; }
        public KoRet3 KoRet { get; set; }
        public KoRetYds3 KoRetYds { get; set; }
        public KoRetAvgYds3 KoRetAvgYds { get; set; }
        public KoTD3 KoTD { get; set; }
        public KoOS3 KoOS { get; set; }
        public KoOSR3 KoOSR { get; set; }
        public Punts3 Punts { get; set; }
        public PuntYds3 PuntYds { get; set; }
        public PuntNetYds3 PuntNetYds { get; set; }
        public PuntLng3 PuntLng { get; set; }
        public PuntAvg3 PuntAvg { get; set; }
        public PuntNetAvg3 PuntNetAvg { get; set; }
        public PuntBlk3 PuntBlk { get; set; }
        public PuntOOB3 PuntOOB { get; set; }
        public PuntDown3 PuntDown { get; set; }
        public PuntIn203 PuntIn20 { get; set; }
        public PuntIn20Pct3 PuntIn20Pct { get; set; }
        public PuntTB3 PuntTB { get; set; }
        public PuntTBPct3 PuntTBPct { get; set; }
        public PuntFC3 PuntFC { get; set; }
        public PuntRet3 PuntRet { get; set; }
        public PuntRetYds3 PuntRetYds { get; set; }
        public PuntRetAvg3 PuntRetAvg { get; set; }
        public FirstDownsTotal2 FirstDownsTotal { get; set; }
        public FirstDownsPass2 FirstDownsPass { get; set; }
        public FirstDownsRush2 FirstDownsRush { get; set; }
        public FirstDownsPenalty2 FirstDownsPenalty { get; set; }
        public ThirdDowns2 ThirdDowns { get; set; }
        public ThirdDownsAtt2 ThirdDownsAtt { get; set; }
        public ThirdDownsPct2 ThirdDownsPct { get; set; }
        public FourthDowns2 FourthDowns { get; set; }
        public FourthDownsAtt2 FourthDownsAtt { get; set; }
        public FourthDownsPct2 FourthDownsPct { get; set; }
        public Penalties2 Penalties { get; set; }
        public PenaltyYds2 PenaltyYds { get; set; }
        public OffensePlays2 OffensePlays { get; set; }
        public OffenseYds2 OffenseYds { get; set; }
        public OffenseAvgYds2 OffenseAvgYds { get; set; }
        public TotalTD2 TotalTD { get; set; }
        public PointsFor2 PointsFor { get; set; }
        public PointsAgainst2 PointsAgainst { get; set; }
        public PointDifferential2 PointDifferential { get; set; }
    }

    public class Player2
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Position { get; set; }
    }

    public class TackleSolo4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class TackleTotal4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class TackleAst4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Sacks4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class SackYds4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Safeties4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class TacklesForLoss4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Interceptions4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class IntTD4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class IntYds4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class IntAverage4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class IntLng4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassesDefended4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Stuffs4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class StuffYds4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KB4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Fumbles4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FumLost4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FumForced4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FumOwnRec4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FumOppRec4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FumRecYds4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FumTotalRec4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FumTD4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KrRet4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KrYds4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KrAvg4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KrLng4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KrTD4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Kr20Plus4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Kr40Plus4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KrFC4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KrFum4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PrRet4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PrYds4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PrAvg4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PrLng4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PrTD4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Pr20Plus4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Pr40Plus4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PrFC4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PrFum4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassAttempts4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassCompletions4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassPct4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassYards2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassAvg4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassYardsPerAtt4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassTD4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassTDPct4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassInt4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassIntPct4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassLng4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Pass20Plus4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Pass40Plus4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassSacks4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassSackY4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class QBRating4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RushAttempts4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RushYards4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RushAverage4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RushTD4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RushLng4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Rush20Plus4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Rush40Plus4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RushFumbles4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Targets2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Receptions4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RecYards4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RecAverage4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RecTD4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RecLng4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Rec20Plus4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Rec40Plus4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RecFumbles4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Punts4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntYds4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntNetYds4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntLng4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntAvg4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntNetAvg4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntBlk4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntOOB4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntDown4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntIn204
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntIn20Pct4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntTB4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntTBPct4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntFC4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntRet4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntRetYds4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PuntRetAvg4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgBlk4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgMade4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgAtt4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgPct4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgMade1193
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgAtt1193
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Fg119Pct3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgMade20293
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgAtt20293
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Fg2029Pct3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgMade30393
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgAtt30393
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Fg3039Pct3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgMade40493
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgAtt40493
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Fg4049Pct3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgMade50Plus4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgAtt50Plus4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Fg50PlusPct4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgLng4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class XpBlk4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class XpMade4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class XpAtt4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class XpPct4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgAndXpPts4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Kickoffs4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoYds4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoOOB4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoAvg4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoTB4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoPct4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoRet4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoRetYds4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoRetAvgYds4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoTD4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoOS4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class KoOSR4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Stats2
    {
        public TackleSolo4 TackleSolo { get; set; }
        public TackleTotal4 TackleTotal { get; set; }
        public TackleAst4 TackleAst { get; set; }
        public Sacks4 Sacks { get; set; }
        public SackYds4 SackYds { get; set; }
        public Safeties4 Safeties { get; set; }
        public TacklesForLoss4 TacklesForLoss { get; set; }
        public Interceptions4 Interceptions { get; set; }
        public IntTD4 IntTD { get; set; }
        public IntYds4 IntYds { get; set; }
        public IntAverage4 IntAverage { get; set; }
        public IntLng4 IntLng { get; set; }
        public PassesDefended4 PassesDefended { get; set; }
        public Stuffs4 Stuffs { get; set; }
        public StuffYds4 StuffYds { get; set; }
        public KB4 KB { get; set; }
        public Fumbles4 Fumbles { get; set; }
        public FumLost4 FumLost { get; set; }
        public FumForced4 FumForced { get; set; }
        public FumOwnRec4 FumOwnRec { get; set; }
        public FumOppRec4 FumOppRec { get; set; }
        public FumRecYds4 FumRecYds { get; set; }
        public FumTotalRec4 FumTotalRec { get; set; }
        public FumTD4 FumTD { get; set; }
        public KrRet4 KrRet { get; set; }
        public KrYds4 KrYds { get; set; }
        public KrAvg4 KrAvg { get; set; }
        public KrLng4 KrLng { get; set; }
        public KrTD4 KrTD { get; set; }
        public Kr20Plus4 Kr20Plus { get; set; }
        public Kr40Plus4 Kr40Plus { get; set; }
        public KrFC4 KrFC { get; set; }
        public KrFum4 KrFum { get; set; }
        public PrRet4 PrRet { get; set; }
        public PrYds4 PrYds { get; set; }
        public PrAvg4 PrAvg { get; set; }
        public PrLng4 PrLng { get; set; }
        public PrTD4 PrTD { get; set; }
        public Pr20Plus4 Pr20Plus { get; set; }
        public Pr40Plus4 Pr40Plus { get; set; }
        public PrFC4 PrFC { get; set; }
        public PrFum4 PrFum { get; set; }
        public PassAttempts4 PassAttempts { get; set; }
        public PassCompletions4 PassCompletions { get; set; }
        public PassPct4 PassPct { get; set; }
        public PassYards2 PassYards { get; set; }
        public PassAvg4 PassAvg { get; set; }
        public PassYardsPerAtt4 PassYardsPerAtt { get; set; }
        public PassTD4 PassTD { get; set; }
        public PassTDPct4 PassTDPct { get; set; }
        public PassInt4 PassInt { get; set; }
        public PassIntPct4 PassIntPct { get; set; }
        public PassLng4 PassLng { get; set; }
        public Pass20Plus4 Pass20Plus { get; set; }
        public Pass40Plus4 Pass40Plus { get; set; }
        public PassSacks4 PassSacks { get; set; }
        public PassSackY4 PassSackY { get; set; }
        public QBRating4 QBRating { get; set; }
        public RushAttempts4 RushAttempts { get; set; }
        public RushYards4 RushYards { get; set; }
        public RushAverage4 RushAverage { get; set; }
        public RushTD4 RushTD { get; set; }
        public RushLng4 RushLng { get; set; }
        public Rush20Plus4 Rush20Plus { get; set; }
        public Rush40Plus4 Rush40Plus { get; set; }
        public RushFumbles4 RushFumbles { get; set; }
        public Targets2 Targets { get; set; }
        public Receptions4 Receptions { get; set; }
        public RecYards4 RecYards { get; set; }
        public RecAverage4 RecAverage { get; set; }
        public RecTD4 RecTD { get; set; }
        public RecLng4 RecLng { get; set; }
        public Rec20Plus4 Rec20Plus { get; set; }
        public Rec40Plus4 Rec40Plus { get; set; }
        public RecFumbles4 RecFumbles { get; set; }
        public Punts4 Punts { get; set; }
        public PuntYds4 PuntYds { get; set; }
        public PuntNetYds4 PuntNetYds { get; set; }
        public PuntLng4 PuntLng { get; set; }
        public PuntAvg4 PuntAvg { get; set; }
        public PuntNetAvg4 PuntNetAvg { get; set; }
        public PuntBlk4 PuntBlk { get; set; }
        public PuntOOB4 PuntOOB { get; set; }
        public PuntDown4 PuntDown { get; set; }
        public PuntIn204 PuntIn20 { get; set; }
        public PuntIn20Pct4 PuntIn20Pct { get; set; }
        public PuntTB4 PuntTB { get; set; }
        public PuntTBPct4 PuntTBPct { get; set; }
        public PuntFC4 PuntFC { get; set; }
        public PuntRet4 PuntRet { get; set; }
        public PuntRetYds4 PuntRetYds { get; set; }
        public PuntRetAvg4 PuntRetAvg { get; set; }
        public FgBlk4 FgBlk { get; set; }
        public FgMade4 FgMade { get; set; }
        public FgAtt4 FgAtt { get; set; }
        public FgPct4 FgPct { get; set; }
        public FgMade1193 FgMade1_19 { get; set; }
        public FgAtt1193 FgAtt1_19 { get; set; }
        public Fg119Pct3 Fg1_19Pct { get; set; }
        public FgMade20293 FgMade20_29 { get; set; }
        public FgAtt20293 FgAtt20_29 { get; set; }
        public Fg2029Pct3 Fg20_29Pct { get; set; }
        public FgMade30393 FgMade30_39 { get; set; }
        public FgAtt30393 FgAtt30_39 { get; set; }
        public Fg3039Pct3 Fg30_39Pct { get; set; }
        public FgMade40493 FgMade40_49 { get; set; }
        public FgAtt40493 FgAtt40_49 { get; set; }
        public Fg4049Pct3 Fg40_49Pct { get; set; }
        public FgMade50Plus4 FgMade50Plus { get; set; }
        public FgAtt50Plus4 FgAtt50Plus { get; set; }
        public Fg50PlusPct4 Fg50PlusPct { get; set; }
        public FgLng4 FgLng { get; set; }
        public XpBlk4 XpBlk { get; set; }
        public XpMade4 XpMade { get; set; }
        public XpAtt4 XpAtt { get; set; }
        public XpPct4 XpPct { get; set; }
        public FgAndXpPts4 FgAndXpPts { get; set; }
        public Kickoffs4 Kickoffs { get; set; }
        public KoYds4 KoYds { get; set; }
        public KoOOB4 KoOOB { get; set; }
        public KoAvg4 KoAvg { get; set; }
        public KoTB4 KoTB { get; set; }
        public KoPct4 KoPct { get; set; }
        public KoRet4 KoRet { get; set; }
        public KoRetYds4 KoRetYds { get; set; }
        public KoRetAvgYds4 KoRetAvgYds { get; set; }
        public KoTD4 KoTD { get; set; }
        public KoOS4 KoOS { get; set; }
        public KoOSR4 KoOSR { get; set; }
    }

    public class PlayerEntry2
    {
        public Player2 player { get; set; }
        public Stats2 stats { get; set; }
    }

    public class HomePlayers
    {
        public List<PlayerEntry2> playerEntry { get; set; }
    }

    public class HomeTeam2
    {
        public HomeTeamStats homeTeamStats { get; set; }
        public HomePlayers homePlayers { get; set; }
    }

    public class BoxScore
    {
        public string lastUpdatedOn { get; set; }
        public Game game { get; set; }
        public QuarterSummary quarterSummary { get; set; }
        public AwayTeam2 awayTeam { get; set; }
        public HomeTeam2 homeTeam { get; set; }
    }

    public class GameBoxscore : IFeedRoot
    {
        public BoxScore gameboxscore { get; set; }
    }
}
