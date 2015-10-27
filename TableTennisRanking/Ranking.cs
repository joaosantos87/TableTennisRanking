using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableTennisRanking
{
    public class Ranking
    {
        public Ranking(DateTime start, DateTime end, int champ=-1)
        {
            DataSet1.gamesRow[] allGames =
                (DataSet1.gamesRow[])FilesAccess.db.games.Select(
                "IdChamp=1 AND Date >= '" + start + "' AND Date <= '" + end + "'");

            //DataSet1.gamesRow[] allGames =
            //    (DataSet1.gamesRow[])FilesAccess.db.games.Select(
            //    "Date >= '" + start + "' AND Date <= '" + end + "'");

            //if(champ!=-1)
            //    allGames = (DataSet1.gamesRow[])allGames.Select(x => x.IdChamp == champ);

            allGames = allGames.OrderBy(x => x.Date).ToArray();

            for (int i = 0; i < FilesAccess.db.player.Count; i++)
            {
                FilesAccess.db.player[i].currentPoints = 1000;
                FilesAccess.db.player[i].currentGames = 0;
            }

            //FilesAccess.db.UpdatePlayer();
            for (int i = 0; i < allGames.Length; i++)
            {
                DataSet1.playerRow playerA = FilesAccess.db.player.Single(x => x.Id == allGames[i].IdPlayerA);
                DataSet1.playerRow playerB = FilesAccess.db.player.Single(x => x.Id == allGames[i].IdPlayerB);

                Tuple<int, int> pointsToDistribuite = AwardPoints(allGames[i].IdPlayerWinner, playerA, playerB);
                float weight = FilesAccess.db.championships.Single(x => x.Id == allGames[i].IdChamp).weight;

                if (playerA.Id == allGames[i].IdPlayerWinner)
                {
                    playerA.currentPoints += Convert.ToInt32(pointsToDistribuite.Item2 * weight);
                    playerB.currentPoints -= Convert.ToInt32(pointsToDistribuite.Item2);
                }
                else
                {
                    playerB.currentPoints += Convert.ToInt32(pointsToDistribuite.Item2* weight);
                    playerA.currentPoints -= Convert.ToInt32(pointsToDistribuite.Item2);
                }
                playerA.currentGames++;
                playerB.currentGames++;
            }

            //FilesAccess.db.UpdatePlayer();
        }

        private bool IsWinnerExpected(int winnerId, DataSet1.playerRow playerA, DataSet1.playerRow playerB)
        {
            if (playerA.currentPoints >= playerB.currentPoints && winnerId == playerA.Id ||
                playerB.currentPoints >= playerA.currentPoints && winnerId == playerB.Id)
                return true;
            else
                return false;
        }

        private Tuple<int, int> AwardPoints(int winnerId, DataSet1.playerRow playerA, DataSet1.playerRow playerB)
        {
            List<Tuple<int, int>> pointsExpected = new List<Tuple<int, int>>();
            List<Tuple<int, int>> pointsUnexpected = new List<Tuple<int, int>>();

            pointsExpected.Add(new Tuple<int, int>(-1, 8));
            pointsExpected.Add(new Tuple<int, int>(13, 7));
            pointsExpected.Add(new Tuple<int, int>(38, 6));
            pointsExpected.Add(new Tuple<int, int>(63, 5));
            pointsExpected.Add(new Tuple<int, int>(88, 4));
            pointsExpected.Add(new Tuple<int, int>(113, 3));
            pointsExpected.Add(new Tuple<int, int>(138, 2));
            pointsExpected.Add(new Tuple<int, int>(163, 2));
            pointsExpected.Add(new Tuple<int, int>(188, 1));
            pointsExpected.Add(new Tuple<int, int>(213, 1));
            pointsExpected.Add(new Tuple<int, int>(238, 0));

            pointsUnexpected.Add(new Tuple<int, int>(-1, 8));
            pointsUnexpected.Add(new Tuple<int, int>(13, 10));
            pointsUnexpected.Add(new Tuple<int, int>(38, 13));
            pointsUnexpected.Add(new Tuple<int, int>(63, 16));
            pointsUnexpected.Add(new Tuple<int, int>(88, 20));
            pointsUnexpected.Add(new Tuple<int, int>(113, 25));
            pointsUnexpected.Add(new Tuple<int, int>(138, 30));
            pointsUnexpected.Add(new Tuple<int, int>(163, 35));
            pointsUnexpected.Add(new Tuple<int, int>(188, 40));
            pointsUnexpected.Add(new Tuple<int, int>(213, 45));
            pointsUnexpected.Add(new Tuple<int, int>(238, 50));

            int dif = Math.Abs(playerA.currentPoints - playerB.currentPoints);
            for (int i = pointsExpected.Count-1; i > -1; i--)
            {
                if (dif > pointsExpected[i].Item1)
                {
                    if (IsWinnerExpected(winnerId, playerA, playerB))
                    {
                        return pointsExpected[i];
                    }
                    else
                        return pointsUnexpected[i];
                }
            }
            return new Tuple<int, int>(0, 0);
        }
    }
}
