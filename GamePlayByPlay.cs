using System;
using System.Collections.Generic;
using System.Text;

namespace api_test
{

    public class Game
    {
        public string date { get; set; }
        public string time { get; set; }
        public AwayTeam awayTeam { get; set; }
        public HomeTeam homeTeam { get; set; }
        public string location { get; set; }
    }

    public class LineOfScrimmage
    {
        public string team { get; set; }
        public string yardLine { get; set; }
    }

    public class RushingPlayer
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class SoloTacklingPlayer
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class StoppedAtPosition
    {
        public string team { get; set; }
        public string yardLine { get; set; }
    }

    public class PenalizedPlayer
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class EnforcedAtPosition
    {
        public string team { get; set; }
        public string yardLine { get; set; }
    }

    public class Penalty
    {
        public string teamAbbreviation { get; set; }
        public PenalizedPlayer penalizedPlayer { get; set; }
        public EnforcedAtPosition enforcedAtPosition { get; set; }
        public string description { get; set; }
        public string isCancelsPlay { get; set; }
        public string yardsPenalized { get; set; }
    }

    //public class Penalties
    //{
    //    public List<Penalty> penalty { get; set; }
    //}

    public class FumblingPlayer
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class RecoveringPlayer
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class AssistedTacklingPlayer1
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class AssistedTacklingPlayer2
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class ForcedByPlayer
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class SoloTacklingPlayer2
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class Fumble
    {
        public string fumblingTeamAbbreviation { get; set; }
        public FumblingPlayer fumblingPlayer { get; set; }
        public string recoveringTeamAbbreviation { get; set; }
        public RecoveringPlayer recoveringPlayer { get; set; }
        public AssistedTacklingPlayer1 assistedTacklingPlayer1 { get; set; }
        public AssistedTacklingPlayer2 assistedTacklingPlayer2 { get; set; }
        public string isMuff { get; set; }
        public string isOutOfBounds { get; set; }
        public string isTackled { get; set; }
        public string isEndedWithTouchdown { get; set; }
        public string isSafety { get; set; }
        public string yardsFromLineOfScrimmage { get; set; }
        public string yardsFumbled { get; set; }
        public string yardsRecovered { get; set; }
        public ForcedByPlayer forcedByPlayer { get; set; }
        public SoloTacklingPlayer2 soloTacklingPlayer { get; set; }
    }

    public class SubPlays
    {
        public Fumble fumble { get; set; }
    }

    public class AssistedTacklingPlayer12
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class AssistedTacklingPlayer22
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class RushingPlay
    {
        public string teamAbbreviation { get; set; }
        public RushingPlayer rushingPlayer { get; set; }
        public SoloTacklingPlayer soloTacklingPlayer { get; set; }
        public StoppedAtPosition stoppedAtPosition { get; set; }
        public string isOutOfBounds { get; set; }
        public string isTackled { get; set; }
        public string isEndedWithTouchdown { get; set; }
        public string isTwoPointConversion { get; set; }
        public string isFirstDownPenalty { get; set; }
        public string isNoPlay { get; set; }
        public string yardsRushed { get; set; }
        public Penalties penalties { get; set; }
        public SubPlays subPlays { get; set; }
        public AssistedTacklingPlayer12 assistedTacklingPlayer1 { get; set; }
        public AssistedTacklingPlayer22 assistedTacklingPlayer2 { get; set; }
    }

    public class KickingPlayer
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class KickedFromPosition
    {
        public string team { get; set; }
        public string yardLine { get; set; }
    }

    public class StoppedAtPosition2
    {
        public string team { get; set; }
        public string yardLine { get; set; }
    }

    public class RetrievingPlayer
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class RetrievedAtPosition
    {
        public string team { get; set; }
        public string yardLine { get; set; }
    }

    public class SoloTacklingPlayer3
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class BlockingPlayer
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class FumblingPlayer2
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class RecoveringPlayer2
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class Fumble2
    {
        public string fumblingTeamAbbreviation { get; set; }
        public FumblingPlayer2 fumblingPlayer { get; set; }
        public string recoveringTeamAbbreviation { get; set; }
        public RecoveringPlayer2 recoveringPlayer { get; set; }
        public string isMuff { get; set; }
        public string isOutOfBounds { get; set; }
        public string isTackled { get; set; }
        public string isEndedWithTouchdown { get; set; }
        public string isSafety { get; set; }
        public string yardsFromLineOfScrimmage { get; set; }
        public string yardsFumbled { get; set; }
        public string yardsRecovered { get; set; }
    }

    public class SubPlays2
    {
        public Fumble2 fumble { get; set; }
    }

    public class PenalizedPlayer2
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class EnforcedAtPosition2
    {
        public string team { get; set; }
        public string yardLine { get; set; }
    }

    public class Penalty2
    {
        public string teamAbbreviation { get; set; }
        public PenalizedPlayer2 penalizedPlayer { get; set; }
        public EnforcedAtPosition2 enforcedAtPosition { get; set; }
        public string description { get; set; }
        public string isCancelsPlay { get; set; }
        public string yardsPenalized { get; set; }
    }

    //public class Penalties2
    //{
    //    public List<Penalty2> penalty { get; set; }
    //}

    public class KickingPlay
    {
        public string kickingTeamAbbreviation { get; set; }
        public KickingPlayer kickingPlayer { get; set; }
        public KickedFromPosition kickedFromPosition { get; set; }
        public StoppedAtPosition2 stoppedAtPosition { get; set; }
        public string isKickoff { get; set; }
        public string isPunt { get; set; }
        public string isBlocked { get; set; }
        public string isTouchback { get; set; }
        public string isSafety { get; set; }
        public string isOutOfBounds { get; set; }
        public string isTouchdown { get; set; }
        public string isFairCatch { get; set; }
        public string isLanded { get; set; }
        public string isOnside { get; set; }
        public string isFirstDownPenalty { get; set; }
        public string isNoPlay { get; set; }
        public string yardsKicked { get; set; }
        public string yardsReturned { get; set; }
        public string retrievingTeamAbbreviation { get; set; }
        public RetrievingPlayer retrievingPlayer { get; set; }
        public RetrievedAtPosition retrievedAtPosition { get; set; }
        public SoloTacklingPlayer3 soloTacklingPlayer { get; set; }
        public BlockingPlayer blockingPlayer { get; set; }
        public SubPlays2 subPlays { get; set; }
        public Penalties2 penalties { get; set; }
    }

    public class PassingPlayer
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class ReceivingPlayer
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class SoloTacklingPlayer4
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Position { get; set; }
        public string JerseyNumber { get; set; }
    }

    public class ReceivedAtPosition
    {
        public string team { get; set; }
        public string yardLine { get; set; }
    }

    public class StoppedAtPosition3
    {
        public string team { get; set; }
        public string yardLine { get; set; }
    }

    public class AssistedTacklingPlayer13
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class AssistedTacklingPlayer23
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class PenalizedPlayer3
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class EnforcedAtPosition3
    {
        public string team { get; set; }
        public string yardLine { get; set; }
    }

    public class Penalty3
    {
        public string teamAbbreviation { get; set; }
        public PenalizedPlayer3 penalizedPlayer { get; set; }
        public EnforcedAtPosition3 enforcedAtPosition { get; set; }
        public string description { get; set; }
        public string isCancelsPlay { get; set; }
        public string yardsPenalized { get; set; }
    }

    public class Penalties3
    {
        public List<Penalty3> penalty { get; set; }
    }

    public class PassingPlay
    {
        public string teamAbbreviation { get; set; }
        public PassingPlayer passingPlayer { get; set; }
        public ReceivingPlayer receivingPlayer { get; set; }
        public SoloTacklingPlayer4 soloTacklingPlayer { get; set; }
        public string isCompleted { get; set; }
        public string isOutOfBounds { get; set; }
        public string isTackled { get; set; }
        public string isEndedWithTouchdown { get; set; }
        public string isTwoPointConversion { get; set; }
        public string isFirstDownPenalty { get; set; }
        public string isNoPlay { get; set; }
        public string yardsPassed { get; set; }
        public string yardsRushed { get; set; }
        public string yardsIntercepted { get; set; }
        public string totalYardsGained { get; set; }
        public ReceivedAtPosition receivedAtPosition { get; set; }
        public StoppedAtPosition3 stoppedAtPosition { get; set; }
        public AssistedTacklingPlayer13 assistedTacklingPlayer1 { get; set; }
        public AssistedTacklingPlayer23 assistedTacklingPlayer2 { get; set; }
        public Penalties3 penalties { get; set; }
    }

    public class KickingPlayer2
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class CenterPlayer
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class HoldingPlayer
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class KickedFromPosition2
    {
        public string team { get; set; }
        public string yardLine { get; set; }
    }

    public class KickAttempt
    {
        public string teamAbbreviation { get; set; }
        public KickingPlayer2 kickingPlayer { get; set; }
        public CenterPlayer centerPlayer { get; set; }
        public HoldingPlayer holdingPlayer { get; set; }
        public KickedFromPosition2 kickedFromPosition { get; set; }
        public string isFieldGoal { get; set; }
        public string isExtraPoint { get; set; }
        public string isBlocked { get; set; }
        public string isGood { get; set; }
        public string isFirstDownPenalty { get; set; }
        public string isNoPlay { get; set; }
        public string yardsKicked { get; set; }
    }

    public class PassingPlayer2
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class SoloTacklingPlayer5
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class SackedAtPosition
    {
        public string team { get; set; }
        public string yardLine { get; set; }
    }

    public class FumblingPlayer3
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class ForcedByPlayer2
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class RecoveringPlayer3
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class SoloTacklingPlayer6
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class Fumble3
    {
        public string fumblingTeamAbbreviation { get; set; }
        public FumblingPlayer3 fumblingPlayer { get; set; }
        public ForcedByPlayer2 forcedByPlayer { get; set; }
        public string recoveringTeamAbbreviation { get; set; }
        public RecoveringPlayer3 recoveringPlayer { get; set; }
        public string isMuff { get; set; }
        public string isOutOfBounds { get; set; }
        public string isTackled { get; set; }
        public string isEndedWithTouchdown { get; set; }
        public string isSafety { get; set; }
        public string yardsFromLineOfScrimmage { get; set; }
        public string yardsFumbled { get; set; }
        public string yardsRecovered { get; set; }
        public SoloTacklingPlayer6 soloTacklingPlayer { get; set; }
    }

    public class SubPlays3
    {
        public Fumble3 fumble { get; set; }
    }

    public class SackingPlay
    {
        public string teamAbbreviation { get; set; }
        public PassingPlayer2 passingPlayer { get; set; }
        public SoloTacklingPlayer5 soloTacklingPlayer { get; set; }
        public SackedAtPosition sackedAtPosition { get; set; }
        public string isFirstDownPenalty { get; set; }
        public string isNoPlay { get; set; }
        public string yardsLost { get; set; }
        public SubPlays3 subPlays { get; set; }
    }

    public class PenalizedPlayer4
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class EnforcedAtPosition4
    {
        public string team { get; set; }
        public string yardLine { get; set; }
    }

    public class Penalty4
    {
        public string teamAbbreviation { get; set; }
        public PenalizedPlayer4 penalizedPlayer { get; set; }
        public EnforcedAtPosition4 enforcedAtPosition { get; set; }
        public string description { get; set; }
        public string isCancelsPlay { get; set; }
        public string yardsPenalized { get; set; }
    }

    public class PenaltyPlay
    {
        public List<Penalty4> penalty { get; set; }
        public string isFirstDownPenalty { get; set; }
        public string isNoPlay { get; set; }
    }

    public class Play
    {
        public string currentDown { get; set; }
        public string yardsRemaining { get; set; }
        public LineOfScrimmage lineOfScrimmage { get; set; }
        public string quarter { get; set; }
        public string time { get; set; }
        public string description { get; set; }
        public RushingPlay rushingPlay { get; set; }
        public KickingPlay kickingPlay { get; set; }
        public PassingPlay passingPlay { get; set; }
        public KickAttempt kickAttempt { get; set; }
        public SackingPlay sackingPlay { get; set; }
        public PenaltyPlay penaltyPlay { get; set; }
    }

    public class Plays
    {
        public List<Play> play { get; set; }
    }

    public class PlayByPlay
    {
        public string lastUpdatedOn { get; set; }
        public Game game { get; set; }
        public Plays plays { get; set; }
    }

    public class GamePlayByPlay : IFeedRoot
    {
        public PlayByPlay gameplaybyplay { get; set; }
    }
}
