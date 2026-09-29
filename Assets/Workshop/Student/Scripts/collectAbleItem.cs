using Searching;
using UnityEngine;

namespace Solution
{
    public class CollectAbleItem : Identity
    {
        public override bool Hit()
        {
            bool IsHasItemAmount = mapGenerator.player.inventory.HasItem(ItemToOpen, ItemAmountToOpen);
            if (IsHasItemAmount)
            {
                mapGenerator.player.inventory.UseItem(ItemToOpen, ItemAmountToOpen);
                leaderboard.gameObject.SetActive(true);

                Debug.Log("You win");
                //add code to manage leaderboard scores

                int score = CalculateScore();
                string playerName = mapGenerator.player.Name;
                leaderboard.RecordScore(new PlayerScore(playerName, score));
                leaderboard.ShowleaderBoard();

                return true;
            }
            else
            {
                Debug.Log("Need Item " + ItemToOpen + " to Open");
                return false;
            }
        }

    }
}

