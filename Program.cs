Dictionary<String, String> leetCorrespondence = new Dictionary<string, string>(){
    {"A", "4"},
    {"B", "I3"},
    {"C", "["},
    {"D", ")"},
    {"E", "3"},
    {"F", "|="},
    {"G", "&"},
    {"H", "#"},
    {"I", "1"},
    {"J", ",_|"},
    {"K", ">|"},
    {"L", "1"},
    {"M", @"/\/\"},
    {"N", "^/"},
	{"Ñ", "+N" },
    {"O", "0"},
    {"P", "|*"},
    {"Q", "(_,)"},
    {"R", "I2"},
    {"S", "5"},
    {"T", "7"},
    {"U", "(_)"},
    {"V", @"\/"},
    {"W", @"\/\/"},
    {"X", "><"},
    {"Y", "j"},
    {"Z", "2"}
};

Console.WriteLine("Leet Translator");
string translatedString = LeetTranslator("ho la", leetCorrespondence);
Console.WriteLine(translatedString);

string LeetTranslator(string originalString, Dictionary<String,String> leetAlphabet) {
    string translatedString = "";

    foreach(char c in originalString) {
        if(leetAlphabet.ContainsKey(c.ToString().ToUpper())){
            translatedString += leetAlphabet[c.ToString().ToUpper()];
        } else {
            translatedString += c;
        }
    }

    return translatedString;
}
