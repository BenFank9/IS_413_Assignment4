using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IS_413_Assignment4.Models
{
    public class ArchiveSuggestions
    {
        //make a new list for suggestions
        private static List<UserSuggestions> SuggestionsList = new List<UserSuggestions>();

        //lambda is doing Suggestions(SuggestionsList)
        public static IEnumerable<UserSuggestions> Suggestions => SuggestionsList;

        public static void AddSuggestion(UserSuggestions suggestion)
        {
            //adding a suggestion to the suggestion list!
            SuggestionsList.Add(suggestion);
        }
    }
}
