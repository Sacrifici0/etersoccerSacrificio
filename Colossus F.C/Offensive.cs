using Core.Games;
using Core.Player;
using Core.Utils;

namespace Teams.Colossus
{
    public class Offensive : TeamPlayer
    {
        public override void OnUpdate()
        {
            var ballPosition = GetBallPosition();
            var directionToBall = GetDirectionTo(ballPosition);
            MoveBy(directionToBall);
            GoTo(FieldPosition.E3);
        }

        public override void OnReachBall()
        {
            var rivalGoalPosition = GetRivalGoalPosition();
            var directionToRivaGoal = GetDirectionTo(rivalGoalPosition);
            ShootBall(directionToRivaGoal, ShootForce.High);
        }

        public override void OnScoreBoardChanged(ScoreBoard scoreBoard)
        {
        }

        public override FieldPosition GetInitialPosition() => FieldPosition.C2;

        public override string GetPlayerDisplayName() => "Sacrificio";
    }
}