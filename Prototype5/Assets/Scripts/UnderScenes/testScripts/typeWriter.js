#pragma strict
 
var displayText : TextMesh;
 
var textShownOnScreen: String ;
var fullText : String = "The text you want shown on screen with typewriter effect.";
var wordsPerSecond : float = 2; // speed of typewriter, words per second
var timeElapsed : float = 0;   
  
function Update()
{
    timeElapsed += Time.deltaTime;
    textShownOnScreen = GetWords(fullText, timeElapsed * wordsPerSecond);
    displayText.text = textShownOnScreen;
}
  
function GetWords(text : String, wordCount : int): String
{
    var words : int = wordCount;
  
    // loop through each character in text
    for (var i : int = 0; i < text.Length; i++)
    { 
        if (text[i] == ' ')
        {
            words--;
        }
  
        if (words <= 0)
        {
            return text.Substring(0, i);
        }
    }
  
    return text;
}