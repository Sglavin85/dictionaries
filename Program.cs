using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
        Create a dictionary with key value pairs to
        represent words (key) and its definition (value)
    */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("Sad", "The feeling of students when they do not understand something in C#");
            wordsAndDefinitions.Add("Tired", "The feeling of students when the clock reads 4pm");
            wordsAndDefinitions.Add("Excited", "The feeling of students when something finally works");
            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */
            Console.WriteLine(wordsAndDefinitions["Sad"]);
            Console.WriteLine(wordsAndDefinitions["Tired"]);

            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            }

            //Practice List of Dictionaries about Words

            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();




            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence

                Example of one dictionary in the list:
                {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                }
            */



            // Create dictionary to represent a few words
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary
            excitedWord.Add("word", "excited");
            excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excitedWord.Add("part of speech", "adjective");
            excitedWord.Add("example sentence", "I am excited to learn C#!");

            // Add Dictionary to your `dictionaryOfWords` list
            dictionaryOfWords.Add(excitedWord);

            // create another Dictionary and add that to the list

            Dictionary<string, string> wordWord = new Dictionary<string, string>() {
                {"word", "word"},
                {"definition", "a single distinct meaningful element of speech or writing, used with others (or sometimes alone) to form a sentence and typically shown with a space on either side when written or printed."},
                {"part of speech", "noun"},
                {"example", "This sentance is a collection of words"}
            };

            dictionaryOfWords.Add(wordWord);

            /*
                Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            // Iterate the List of Dictionaries

            foreach (Dictionary<string, string> word in dictionaryOfWords)
            {
                // Iterate the KeyValuePairs of the Dictionary
                foreach (KeyValuePair<string, string> wordData in word)
                {
                    Console.WriteLine($"{wordData.Key}: {wordData.Value}");
                }
            };

            //Practice: English Idioms

            Dictionary<string, List<string>> idioms = new Dictionary<string, List<string>>();
            idioms.Add("Penny", new List<string> { "A", "penny", "for", "your", "thoughts" });
            idioms.Add("Injury", new List<string> { "Add", "insult", "to", "injury" });
            idioms.Add("Moon", new List<string> { "Once", "in", "a", "blue", "moon" });
            idioms.Add("Grape", new List<string> { "I", "heard", "it", "through", "the", "grapevine" });
            idioms.Add("Murder", new List<string> { "Kill", "two", "birds", "with", "one", "stone" });
            idioms.Add("Limbs", new List<string> { "It", "costs", "an", "arm", "and", "a", "leg" });
            idioms.Add("Grain", new List<string> { "Take", "what", "someone", "says", "with", "a", "grain", "of", "salt" });
            idioms.Add("Fences", new List<string> { "I'm", "on", "the", "fence", "about", "it" });
            idioms.Add("Sheep", new List<string> { "Pulled", "the", "wool", "over", "his", "eyes" });
            idioms.Add("Lucifer", new List<string> { "Speak", "of", "the", "devil" });

            foreach (KeyValuePair<string, List<string>> idiom in idioms)
            {
                string sentance = "";
                foreach (string word in idiom.Value)
                {
                    sentance = $"{sentance} {word}";
                };
                Console.WriteLine($"{idiom.Key}: {sentance}");
            };


            //Challenge: Randall's Car Lot in C#

            List<Dictionary<string, object>> vehicles = new List<Dictionary<string, object>>();


            Dictionary<string, object> vehicle = new Dictionary<string, object>(){
                {"year", 2008},
                {"model", "Damfresh"},
                {"make", "Biotraxquote"},
                {"color", "sky magenta"}
            };


            string salesId = "ecb1c841-1a43-4a7c-896e-712d2ec39c71";

            List<string> botsfordEmails = new List<string>() {
                {"beatae_sonny@hotmail.com"},
                {"shaina@aol.com"}
            };

            Dictionary<string, object> salesAgent = new Dictionary<string, object>(){
                {"mobile", "(860) 478-6975"},
                {"lastName", "Botsford"},
                {"firstName", "Shaina"},
                {"emails", botsfordEmails}
            };

            string purchaseDate = "2017-11-15";
            double grossProfit = 871.26;

            Dictionary<string, string> credit = new Dictionary<string, string>() {
                {"creditProvider", "J.P. Morgan Chase & CO"},
                {"account", "601109582720302"}
            };

            Dictionary<string, object> one = new Dictionary<string, object>() {
                {"vehicle", vehicle},
                {"salesId", salesId},
                {"salesAgent", salesAgent},
                {"purchaseDate", purchaseDate},
                {"grossProfit", grossProfit},
                {"credit", credit}
            };

            vehicles.Add(one);

            vehicles.ForEach(record =>
            {
                foreach (KeyValuePair<string, object> item in record)
                    Console.WriteLine($"{item.Key}: {item.Value}");
            }
            );

            //Challenge: The family Dictionary

            var myFamily = new Dictionary<string, Dictionary<string, string>>();


            myFamily.Add("mother", new Dictionary<string, string>() {
                {"name", "Stacy"},
                {"age", "67"}
            });

            myFamily.Add("father", new Dictionary<string, string>() {
                {"name", "Matthew"},
                {"age", "65"}
            });

            myFamily.Add("brother", new Dictionary<string, string>() {
                {"name", "Chris"},
                {"age", "36"}
            });

            foreach (KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
            {
                Console.WriteLine($"{familyMember.Value["name"]} is my {familyMember.Key} and is {familyMember.Value["age"]} years old.");
            }


            // Challenge: Planets and Probes

            var planetList = new List<string>() {
                "Mercury",
                "Venus",
                "Earth",
                "Mars",
                "Jupiter",
                "Saturn",
                "Uranus",
                "Neptune"
            };

            var probeDesitinations = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("Viking 1", "Mars"),
                new KeyValuePair<string, string>("Mariner 1", "Venus"),
                new KeyValuePair<string, string>("Voyager 1", "Jupiter"),
                new KeyValuePair<string, string>("Voyager 1", "Saturn")
            };

            foreach (string planet in planetList)
            {
                List<string> matchingProbes = new List<string>();

                foreach (KeyValuePair<string, string> probe in probeDesitinations)
                {
                    if (probe.Value == planet)
                    {
                        matchingProbes.Add(probe.Key);
                    }
                }
                Console.WriteLine($"{planet}: {string.Join(",", matchingProbes)}");
            }
        }

    }
}

