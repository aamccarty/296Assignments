using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheKidPage.Models
{
    public class Repository
    {
        public static List<JokeForm> responses = new List<JokeForm>();

        public static IEnumerable<JokeForm> Responses
        {
            get
            {
                return responses;
            }
        }
        public static void AddResponse(JokeForm response)
        {
            responses.Add(response);
        }
    }
}
