using System.Collections.Generic;

namespace Hearthstone_Deck_Tracker.Hearthstone
{
	public class DeckState
	{
		public DeckState(IEnumerable<Card> remainingInDeck, IEnumerable<Card> removedFromDeck)
		{
			RemovedFromDeck = removedFromDeck;
			RemainingInDeck = remainingInDeck;

			// Shermbo test comments - git test
			// another line
		}

		public IEnumerable<Card> RemainingInDeck { get; }
		public IEnumerable<Card> RemovedFromDeck { get; }
	}
}
